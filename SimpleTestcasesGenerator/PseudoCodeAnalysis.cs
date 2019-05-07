using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTestcasesGenerator
{
    class PseudoCodeAnalysis
    {

        static public List<Variable> GetVariables(string code)
        {
            List<Variable> variables = new List<Variable>();

            string[] lines = code.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].ToLower().Contains("if") || lines[i].ToLower().Contains("while"))
                {
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].ToLower().Contains("endif") || lines[j].ToLower().Contains("endwhile"))
                        {
                            i = j - 1;
                            break;
                        }
                    }
                }
                else if (lines[i].ToLower().Contains("read") ||
                    lines[i].ToLower().Contains("get") ||
                    lines[i].ToLower().Contains("input") ||
                    lines[i].ToLower().Contains("accept")) //Get all declared variables
                {
                    string[] declareLine = lines[i].Split(' ');
                    if (lines[i].Contains(','))
                    {
                        for (int j = 1; j < declareLine.Length; j++)
                        {
                            if (j + 1 == declareLine.Length)
                            {
                                if (!variables.Exists(x => x.Name == declareLine[j].Substring(0, declareLine[j].Length).Trim()))
                                    variables.Add(new Variable(declareLine[j].Substring(0, declareLine[j].Length).Trim(), null));
                            }
                            else
                            {
                                if (!variables.Exists(x => x.Name == declareLine[j].Substring(0, declareLine[j].Length - 1).Trim()))
                                    variables.Add(new Variable(declareLine[j].Substring(0, declareLine[j].Length - 1).Trim(), null));
                            }
                        }
                    }
                    else
                    {
                        if (!variables.Exists(x => x.Name == declareLine[1].Trim()))
                            variables.Add(new Variable(declareLine[1].Trim(), null));
                    }
                }  //------------------------------------------------------------------
                else if (lines[i].Contains('='))
                {
                    //if (lines[i].ToLower().Contains("set"))
                    //    lines[i] = lines[i].ToLower().Replace("set ", string.Empty);

                    string[] assignmentVariables = lines[i].Split('=');
                    if (!variables.Exists(x => x.Name == assignmentVariables[0].Trim()))
                        variables.Add(new Variable(assignmentVariables[0].Trim(), assignmentVariables[1].Trim()));
                    else
                        variables.Find(x => x.Name == assignmentVariables[0].Trim()).AssignmentVariable
                            = assignmentVariables[1].Trim();
                }
                else if (lines[i].ToLower().Contains("return"))
                {
                    string[] returnValue = lines[i].Split(' ');
                    variables.Find(x => x.Name == returnValue[1].Trim()).IsReturnValue = true;
                }
            }

            return variables;
        }

        static public List<Condition> GetConditions(string code)
        {
            List<Condition> conditions = new List<Condition>();

            string[] lines = code.Split('\n');
            Condition condition;
            for (int i = 0; i < lines.Length; i++)
            {
                if ((lines[i].ToLower().Contains("if") && !lines[i].ToLower().Contains("endif")) ||
                    (lines[i].ToLower().Contains("while") && !lines[i].ToLower().Contains("endwhile")))
                {
                    string[] declareLine = lines[i].Split(' ');
                    condition = new Condition(declareLine[0].ToLower(), declareLine[1], declareLine[2], declareLine[3]);

                    for (int j = i + 1; j < lines.Length; j++)
                        if (!lines[j].ToLower().Contains("endif") && !lines[j].ToLower().Contains("endwhile"))
                            if (!lines[j].ToLower().Contains("else"))
                                condition.Body += lines[j] + ';';
                            else
                                condition.Body += '}' + lines[j].ToLower() + '{';
                        else
                            break;

                    conditions.Add(condition);
                }
            }
            return conditions;
        }

        static public string GenerateCSharpCode(List<Variable> variables, List<Condition> conditions)
        {
            string generatedCode = "using System;\r\n" +
                    "namespace TestApp {\r\n" +
                    "class TestAppClass {\r\n" +
                    "static void Main(string[] args) { Console.Write(TestFunc()); Console.Read(); }\r\n" +
                    "static int TestFunc() {\r\n";

            for (int i = 0; i < variables.Count; i++)
            {
                if (variables[i].AssignmentVariable == null)
                    generatedCode += "int " + variables[i].Name + ";\r\n";
                else
                    generatedCode += "int " + variables[i].Name + '=' + variables[i].AssignmentVariable + ";\r\n";
            }

            for (int i = 0; i < conditions.Count; i++)
            {
                generatedCode += conditions[i].Type + " (" + conditions[i].Left + ' ' + conditions[i].Opera + ' ' +
                    conditions[i].Right + ") {\r\n" + conditions[i].Body + "}\r\n";
            }

            return generatedCode + "return " + variables.Find(x => x.IsReturnValue).Name + "; } } }";
        }

        static public string CompileCode(List<Variable> variables, List<Condition> conditions)
        {
            string code = "";
            string outputMsg = "";

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "CompiledApp.exe";

            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;

            code = GenerateCSharpCode(variables, conditions);

            CompilerResults results = icc.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.Count > 0)
            {
                foreach (CompilerError CompErr in results.Errors)
                {
                    outputMsg = outputMsg +
                                //"Line number " + CompErr.Line +
                                "Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
                outputMsg = "Code Compiled Successfully.";

            return outputMsg;
        }
    }
}

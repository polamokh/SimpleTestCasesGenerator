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
            Variable returnVariable = new Variable();

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
                    lines[i].ToLower().Contains("accept"))
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
                }
                else if (lines[i].Contains('='))
                {
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
                    returnVariable = variables.Find(x => x.Name == returnValue[1].Trim());
                    variables.Remove(returnVariable);
                }
            }
            returnVariable.IsReturnValue = true;
            variables.Add(returnVariable);

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
                                condition.Body += lines[j] + ";\r\n";
                            else
                                condition.Body += "}\r\n" + lines[j].ToLower() + " {\r\n";
                        else
                            break;

                    conditions.Add(condition);
                }
            }
            return conditions;
        }

        static public string GenerateCSharpCode(List<Variable> variables, List<Condition> conditions, bool isAutoTestcases)
        {
            string generatedCode = "using System;\r\n" +
                    "namespace TestApp {\r\n" +
                    "class TestAppClass {\r\n" +
                    "static void Main(string[] args) {\r\n";
            if (isAutoTestcases)
            {
                double numOfTestcases = Math.Pow(3, variables.Count - 1);
                for (int i = 0; i < numOfTestcases; i++)
                    generatedCode += "Console.WriteLine(\"So, Output is \"+TestFunc" + i + "()); " +
                        "Console.WriteLine();\r\n";
            }
            else
                generatedCode += "Console.WriteLine(\"So, Output is \"+TestFunc());\r\n";
            generatedCode += "}\r\n";

            if (isAutoTestcases)
            {
                int numOfVariables = variables.Count - 1;
                int numOfTestcases = Convert.ToInt32(Math.Pow(3, variables.Count - 1));

                int[,] testcasesTable = new int[numOfTestcases, numOfVariables];
                int tmp = numOfTestcases;
                Random rand = new Random();
                for (int i = 0; i < numOfVariables; i++)
                {
                    int prob = 0;
                    tmp /= 3;
                    for (int j = 0; j < numOfTestcases; j++)
                    {
                        int value = 0;
                        if (prob == 1)
                            value = rand.Next(1, 10000);
                        else if (prob == 2)
                            value = rand.Next(-9999, 0);

                        testcasesTable[j, i] = value;

                        if ((j + 1) % tmp == 0)
                            prob++;

                        if (prob > 2)
                            prob = 0;
                    }
                }

                for (int i = 0; i < numOfTestcases; i++)
                {
                    generatedCode += "static int TestFunc" + i + "() {\r\n";
                    generatedCode += "Console.Write(" + "\"If Input is \"" + ");\r\n";
                    for (int j = 0; j < variables.Count; j++)
                    {
                        if (!variables[j].IsReturnValue)
                        {
                            generatedCode += "int " + variables[j].Name + '=' + testcasesTable[i, j] + ";\r\n";
                            if (j + 2 == variables.Count)
                                generatedCode += "Console.WriteLine(" + '"' + variables[j].Name + "\"+" + "\"=\"+" +
                                '"' + testcasesTable[i, j] + "\");\r\n";
                            else
                                generatedCode += "Console.Write(" + '"' + variables[j].Name + "\"+" + "\"=\"+" +
                                '"' + testcasesTable[i, j] + "\"+\", \");\r\n";
                        }
                        else
                        {
                            if (variables[j].AssignmentVariable == null)
                                generatedCode += "int " + variables[j].Name + ";\r\n";
                            else
                                generatedCode += "int " + variables[j].Name + '=' + variables[j].AssignmentVariable + ";\r\n";
                        }
                    }

                    for (int k = 0; k < conditions.Count; k++)
                    {
                        generatedCode += conditions[k].Type + " (" + conditions[k].Left + ' ' + conditions[k].Opera + ' ' +
                            conditions[k].Right + ") {\r\n" + conditions[k].Body + "}\r\n";
                    }

                    generatedCode += "return " + variables.Find(x => x.IsReturnValue).Name + ";\r\n" +
                        "}\r\n";
                }
            }
            else
            {
                generatedCode += "static int TestFunc() {\r\n";
                generatedCode += "Console.Write(" + "\"If Input is \"" + ");\r\n";

                for (int i = 0; i < variables.Count; i++)
                {
                    if (variables[i].AssignmentVariable == null)
                        generatedCode += "int " + variables[i].Name + ";\r\n";
                    else
                    {
                        generatedCode += "int " + variables[i].Name + '=' + variables[i].AssignmentVariable + ";\r\n";
                        if (!variables[i].IsReturnValue)
                        {
                            if (i + 2 == variables.Count)
                                generatedCode += "Console.WriteLine(" + '"' + variables[i].Name + "\"+" + "\"=\"+" +
                                '"' + variables[i].AssignmentVariable + "\");\r\n";
                            else
                                generatedCode += "Console.Write(" + '"' + variables[i].Name + "\"+" + "\"=\"+" +
                                '"' + variables[i].AssignmentVariable + "\"+\", \");\r\n";
                        }
                    }
                }

                for (int i = 0; i < conditions.Count; i++)
                {
                    generatedCode += conditions[i].Type + " (" + conditions[i].Left + ' ' + conditions[i].Opera + ' ' +
                        conditions[i].Right + ") {\r\n" + conditions[i].Body + "}\r\n";
                }

                generatedCode += "return " + variables.Find(x => x.IsReturnValue).Name + ";\r\n" +
                    "}\r\n";
            }

            return generatedCode +
                "}\r\n" +
                "}";
        }

        static public string CompileCode(string cSharpCode)
        {
            string code = "";
            string outputMsg = "";

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "CompiledApp.exe";

            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;

            code = cSharpCode;

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

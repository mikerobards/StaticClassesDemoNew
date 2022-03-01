using Homework;

UserMessagesHM.WelcomeMessage();

double x = RequestDataHM.GetADouble("What is your first number: ");
double y = RequestDataHM.GetADouble("What is your second number: ");

double resultAdd = CalculateDataHM.Add(x, y);
double resultSubtract = CalculateDataHM.Subtract(x, y); 
double resultMultiply = CalculateDataHM.Multiply(x, y); 
double resultDivide =   CalculateDataHM.Divide(x, y);

UserMessagesHM.PrintResultMessage($"{x} + {y} = {resultAdd}");
UserMessagesHM.PrintResultMessage($"{x} - {y} = {resultSubtract}");
UserMessagesHM.PrintResultMessage($"{x} * {y} = {resultMultiply}");
UserMessagesHM.PrintResultMessage($"{x} / {y} = {resultDivide}");


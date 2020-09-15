Step 4
Added the feature to calculate exponents in CalculatorUtil.cs

case "exponent":
                case "^":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;

Step 5
Added "pi" as a possible input for the numeric inputs.
Aswell as a String Format for the operands in the output message "in case the user inputed a long decimal number such as pi".
This was done in the InputConverter.cs

 if(argTextInput == "pi")
            {
                convertedNumber = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749;
                
            }
            else if (!double.TryParse(argTextInput, out convertedNumber)) { 
            throw new ArgumentException("Expected a numeric value. Try again.");
            }
            return convertedNumber;
        }
As well as Program.cs

sb.Append("The result of " + String.Format("{0:0.00}", firstNumber) + operation + String.Format("{0:0.00}", secondNumber) + " is " + String.Format("{0:0.00}", result));




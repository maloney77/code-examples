/*Name: Kyle Maloney
  Class: Programming Languages and Translators
  Section: 1A
  Assignment: Lexical Analyzer
*/


#include <cstring>
#include <iostream>
#include <cctype>
using namespace std;

int main ()
{

	string inputStr;
	int numberLoops;

	cin >> numberLoops;

    cout << numberLoops << endl;
    for(int i = 1; i <= numberLoops; i++)
	{
	    bool stateBool = "good";
        int index = 0;
        int state = 0;

	    cin >> inputStr;
	    if(inputStr == "while" || inputStr.compare("if") == 0 || inputStr.compare("for") == 0 || inputStr.compare("else") == 0)
        {
            cout << "Keyword!" << endl;

        }
        else
        {
        while(stateBool == true && index < inputStr.size())
        {

            switch(state)
            {
                case 0:

                    if(isdigit(inputStr[index]))
                    {
                        state = 1;
                        stateBool = true;
                    }
                    else if (isalpha(inputStr[index]))
                    {
                        index ++;
                        state = 3;
                        stateBool = true;
                    }
                    else if(inputStr[index] == '+' || inputStr[index] == '-')
                    {
                        state = 1;
                        index ++;
                        stateBool = true;
                    }

                    else
                        stateBool = false;
                    break;

                //integer case
                case 1:
                    if(isdigit(inputStr[index]))
                    {
                        index ++;
                        stateBool = true;
                    }
                    else if(inputStr[index] == '.' && isdigit(inputStr[index +1 ]))
                    {
                        state = 4;
                        index ++;
                        stateBool = true;
                    }
                    else if(inputStr[index] == 'A' || inputStr[index] == 'B' || inputStr[index] == 'C' || inputStr[index] == 'D' || inputStr[index] == 'E' || inputStr[index] == 'F' || inputStr[index] == 'H')
                    {
                        state = 5;
                        index ++;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;

                //this case is basically useless because I took it out after everything else worked
                case 2:
                    stateBool = true;
                    break;

                //also identifier case
                case 3:
                    if((isalpha(inputStr[index]) || isdigit(inputStr[index])) && inputStr[index] != 'H')
                    {
                        index++;
                        stateBool = true;
                    }
                    else if(inputStr[index] == '@' || inputStr[index] == '.')
                    {
                        index ++;
                        state = 12;
                        stateBool= true;
                    }
                    else if(inputStr[index]== '_')
                    {
                        state = 6;
                        index ++;
                        stateBool = true;
                    }
                    else if(inputStr[index]== 'H')
                    {
                        state = 5;
                        index ++;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;
                //decimal case
                case 4:
                    if(isdigit(inputStr[index]))
                    {
                        index++;
                        stateBool = true;
                    }
                    else if(inputStr[index] == 'E' && isdigit(inputStr[index-1]))
                    {
                        state = 7;
                        index ++;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;

                //hexadecimal case
                case 5:
                    if(isdigit(inputStr[index]) || inputStr[index] == 'A' || inputStr[index] == 'B' || inputStr[index] == 'C' || inputStr[index] == 'D' || inputStr[index] == 'E' || inputStr[index] == 'F')
                    {
                        index ++;
                        stateBool = true;
                    }
                    else if (inputStr[index] == 'H')
                    {
                        stateBool = true;
                        index++;
                    }
                    else
                        stateBool = false;

                    break;

                //identifier case
                case 6:
                    if(inputStr[index]== '_' || isalpha(inputStr[index]) || isdigit(inputStr[index]))
                    {
                        index++;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;

                //scientific case
                case 7:
                    if(isdigit(inputStr[index]))
                    {
                        index ++;
                        stateBool = true;
                    }
                    else if (inputStr[index] == '-' /*&& inputStr[index - 1] == 'E' && isdigit(inputStr[index +1])*/)
                    {
                        state = 9;
                        index ++;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;

                case 8:
                    if(inputStr[index] == 'o' || inputStr[index] == 'e' || inputStr[index] == 'd')
                    {
                        state = 10;
                        index ++;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;

                //scientific case
                case 9:
                    if(isdigit(inputStr[index]))
                    {
                        index++;
                        stateBool= true;
                    }
                    else
                        stateBool = false;
                    break;

                case 10:
                    if(inputStr[index] == 'm' || inputStr[index] == 'u' || inputStr[index] == 't')
                    {
                        state = 11;
                        index ++;
                        stateBool = true;
                    }
                    break;

                //email case
                case 11:
                    stateBool = true;
                    break;

                case 12:
                    if(isalpha(inputStr[index]) || isdigit(inputStr[index]))
                    {

                        index++;
                        stateBool = true;
                    }
                    else if (inputStr[index] == '@')
                    {
                        index ++;
                        state = 13;
                        stateBool = true;
                    }
                    else if (inputStr[index] == '.')
                    {
                        index ++;
                        state = 14;
                        stateBool = true;
                    }
                    break;

                case 13:
                    if(isalpha(inputStr[index]))
                    {
                        index ++;
                        stateBool = true;
                    }
                    else if(inputStr[index] == '.')
                    {
                        index ++;
                        state = 14;
                        stateBool = true;
                    }
                    break;

                case 14:
                    if(inputStr[index] == 'c' || inputStr[index] == 'n' || inputStr[index] == 'e')
                    {
                        index++;
                        state = 8;
                        stateBool = true;
                    }
                    else
                        stateBool = false;
                    break;

              }
          }
        }

        if(state == 1 && stateBool == true)
            {
                cout << i << ": Integer!" << endl;
            }
        else if(state == 4 && stateBool == true)
            {
                cout << "Decimal!" << endl;
            }
        /*else if(state == 2 && stateBool == true)
            {
                cout << "Keyword!" << endl;
            }*/
        else if(state == 6 && stateBool == true)
            {
                cout << "Identifier!" << endl;
            }
        else if(state == 3 && stateBool == true)
            {
                cout << "Identifier!" << endl;
            }
        else if(state == 5 && stateBool == true)
            {
                cout << "HexaDecimal!" << endl;
            }

        else if(state == 11 && stateBool == true)
            {
                cout << "Email!" << endl;
            }
        else if(state == 7 && stateBool == true)
            {
                cout << "Scientific!" << endl;
            }
        else if(state == 9 && stateBool == true)
            {
                cout << "Scientific!" << endl;
            }
        else if(stateBool == false)
            {
                cout << "INVALID!" << endl;
            }
	}
	return 0;
}

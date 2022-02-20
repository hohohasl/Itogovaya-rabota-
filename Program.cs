using static System.Console;

string[] stringArray = { "hello", "2", "world", ":-)", "88", "-2" };

void PrintStringArray(string[] stringArray)
{
  Write("["); 
  for (int i = 0; i < stringArray.Length; i++)
  {
    Write($"\"{stringArray[i]}\"");
    if (i != stringArray.Length - 1)
    {
      Write(", ");
    }
  }
  Write("]");
}

int SearchStringLessOrEqual3Symbols(string[] stringArray)
{
  int numberOfString = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      numberOfString++;
    }
  }
  return numberOfString;
}

string[] CreateArrayLessOrEqual3Symbols(string[] stringArray, int sizeNewArray)
{
  string[] newStringArray = new string[sizeNewArray];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      newStringArray[j] = stringArray[i];
      j++; 
    }
  }
  return newStringArray;
}


PrintStringArray(stringArray);
int sizeNewArray = SearchStringLessOrEqual3Symbols(stringArray); 
string[] newStringArray = CreateArrayLessOrEqual3Symbols(stringArray, sizeNewArray); 
Write(" --> ");
PrintStringArray(newStringArray);
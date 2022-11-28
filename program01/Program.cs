// Из имеющегося массива строк сформировать массив строк, длина которых меньше или равна 3



void PrintArray(string [] collection) 
{
    

     Console.WriteLine($"[{string.Join(", ", collection)}]");
 
       Console.WriteLine(); 
 }


void ScreeningArray(string [] collection, string [] rez ) 
{ 
   int j = 0; 
for(int i = 0; i < collection.Length; i++)
{  
int c = collection[i].Length;
   
    if (c < 4) 
    {
        
        rez[j] = collection[i];
        j++;
        
    }
}
} 


string [] coll = {"123", "1234", "abc", "abcd", "1a","12ab"}; 
string [] rez= new string [3];
Console.Write("Начальный массив: ");
PrintArray(coll);
ScreeningArray(coll,rez);
Console.Write("Конечный массив: ");
PrintArray(rez);
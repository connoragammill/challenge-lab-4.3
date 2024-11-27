namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 brackets to see if they match");
			string input = Console.ReadLine();//user input
            if (IsValid(input))//this checks to see if it is valid and if the input has a match(s)
            { 
                Console.WriteLine("Brackets matched!"); 
            } 
            else 
            { 
                Console.WriteLine("Brackets not matched"); 
            } 
        } 
        static bool IsValid(string s) //method to check if the input is valid and has a match
        { 
            Stack<char> stack = new Stack<char>(); //stack 
            foreach (char c in s) 
            {
                if (c == '(' || c == '[' || c == '{') //pushes (,[, and { to the stack
				{ 
                    stack.Push(c); 
                } 
                else if (c == ')' || c == ']' || c == '}') //pop off the stack 
				{ 
                    if (stack.Count == 0 || !IsMatch(stack.Pop(), c)) 
                    { 
                        return false; 
                    } 
                } 
            } return stack.Count == 0;
		}

        static bool IsMatch(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')') return true;
            else if (character1 == '[' && character2 == ']') return true;
			else if (character1 == '{' && character2 == '}') return true;
            else return false;
		}
    }
}

namespace RiderKata;

public class CodeSelectAndDelete
{
    public void SelectMeAndThenHitDel() 
    {
        // ** Task 1: Select the whole method using 'extend selection', then delete
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello World");
        }
    }
    
    // ** Task 2: Use 'delete line' to delete comments within this method
    #region hint for task 2
    // Ctrl + Y
    #endregion
    public void UseDeleteLineKeyToDeleteme() 
    {
        // DELETE ME
        for (int i = 0; i < 10; i++)
        {
            // DELETE ME
            Console.WriteLine("Hello World");
            // DELETE ME
        }
        // DELETE ME
    }
    
}
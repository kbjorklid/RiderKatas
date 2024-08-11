namespace RiderKata.CodeNavigation;

// ** TASK 1: Go to FirstMethod by using 'next declaration' navigation
#region Task 1 hint
// Alt + Down
#endregion

/// <summary>
/// This file includes practices to navigate between methods.
/// </summary>
public abstract class CodeNavigationMethods
{
    // TODO:
    // Navigate to next / previous method in a class
    // Use context nav menu (ctrl-shift-g)

    public string FirstMethod() // <-- move cursor here for task 2
    {
        // ** Task 2: Go to usage of this method in 'LastMethod()' by using 'Go to declaration or usages' navigation
        // **         Cursor must be on the method name
        #region Task 2 hint
        // Ctrl + B
        #endregion

        return "foo";
    }


    public string SecondMethod()
    {
        return FourthMethod(); // <-- move cursor here for task 4
        // ** Task 4: Go to declaration of 'FourthMethod()' by using 'Go to declaration or usages' navigation
        #region Task 4 hint
        // Ctrl + B
        #endregion
    }
    
    
    public abstract string FourthMethod();
    // ** Task 5: Go to imlementation of 'FourthMethod()' by using 'Go to declaration or usages' navigation
    #region Task 5 hint
    // Ctrl + Alt + B
    #endregion
    
    public string LastMethod()
    {   
        return FirstMethod();
        // ** Task 3: Go to declaration of 'SecondMethod()' by using 'Previous declaration' navigation
        #region Task 3 hint
        // Alt + Up
        #endregion
    }
    
}

public class Concrete : CodeNavigationMethods
{
    public override string FourthMethod()
    {
        // ** Task 6: Go to base symbol using the 'Navigate to...' menu
        #region Task 6 hint
        // Ctrl + Shift + G
        #endregion
        return "FirstMethod";
    }
}

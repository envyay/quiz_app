namespace QuizApp.Common;

public class Constants
{
    public const int MULTIPLE_CHOICE = 1;
    public const int TRUE_FALSE = 2;
    public const int OPEN_ENDED = 3;

    public const string MULTIPLE_CHOICE_NAME = "Multiple Choice";
    public const string TRUE_FALSE_NAME = "True/False";
    public const string OPEN_ENDED_NAME = "Open Ended";

    public static int QuestionType(string typeName)
    {
        switch (typeName)
        {
            case MULTIPLE_CHOICE_NAME:
                return MULTIPLE_CHOICE;
            case TRUE_FALSE_NAME:
                return TRUE_FALSE;
            case OPEN_ENDED_NAME:
                return OPEN_ENDED;
            default:
                return 0;
        }
    }
}
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Question
{
    private int     _testNumber;     // The test number the question is connected to
    private int     _questionNumber; // The question number in the test
    private string  _questionText;   // The text that makes up the question
    private string  _questionType;   // The type of the question
    private bool    _hasRightAnswer; // This flag is used to determine if the question is MC or T/F
    private Answers _listOfAnswers;  // The list of answers to the question

    private struct Answers
    {
        public string answerSlotA;
        public string answerSlotB;
        public string answerSlotC;
        public string answerSlotD;
    }

	public Question()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public Question(int testNumber, int questionNumber)
    {

    }
}

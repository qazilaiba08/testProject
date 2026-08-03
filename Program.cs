using System;
using System.Runtime.CompilerServices;

class SubscriptionRenewal
{
    static void Main()
    {
 // initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Display the Report Header
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n"
    + "--------------------------------------------------------------");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        // assign Sophia's scores to the studentScores array 
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        // assign Andrew's scores to the studentScores array 
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        // assign Emma's scores to the studentScores array 
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        // assign Logan's scores to the studentScores array 
        studentScores = loganScores;
        else if (currentStudent == "Becky")
    studentScores = beckyScores;
       else if (currentStudent == "Chris")
    studentScores = chrisScores;
       else if (currentStudent == "Eric")
    studentScores = ericScores;
    else if (currentStudent == "Gregor")
    studentScores = gregorScores;
      else
        continue;

     // sum of exam assignment scores
    int examScoreSum = 0;

    // sum of extra credit assignment scores (raw, not yet weighted)
    int extraCreditScoreSum = 0;

    // counters
    int gradedAssignments = 0;
    int extraCreditAssignments = 0;

    // averages and final calculated values
    decimal examScoreAverage = 0;
    decimal extraCreditScoreAverage = 0;
    decimal currentStudentGrade = 0;
    decimal extraCreditPointsEarned = 0;

foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            examScoreSum += score;

        else // this is extra credit - worth 10% of an exam score
            {
            extraCreditScoreSum += score;
            extraCreditAssignments += 1;
            }
    }
   
    examScoreAverage = (decimal) examScoreSum / examAssignments;
    
    // average for extra credit scores
    if (extraCreditAssignments > 0)
        extraCreditScoreAverage = (decimal)extraCreditScoreSum / extraCreditAssignments;

    // final numeric score: exam sum + 10% of extra credit sum, divided by number of exams
    currentStudentGrade = (examScoreSum + (0.10m * extraCreditScoreSum)) / examAssignments;

    // extra credit points earned: 10% of extra credit sum, divided by number of exams
    extraCreditPointsEarned = (0.10m * extraCreditScoreSum) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

       Console.WriteLine($"{name}\t\t{examScoreAverage:0.0}\t\t{currentStudentGrade:0.0}\t{currentStudentLetterGrade}\t{extraCreditPointsEarned:0.0} pts");
    }
    Console.WriteLine("\nPress any key to exit.");
    Console.ReadLine();
}
}
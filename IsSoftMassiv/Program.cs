// See https://aka.ms/new-console-template for more information
static float GetAverageGrade (int[] grades)
{
    float summa = 0;
    for (int i = 0; i < grades.Length; i++)
    {
        summa += grades[i];  
    }
    float average = summa / grades.Length;
    return average;
}
static int GetMaxGrade (int[] grades)
{
    int max = 0;
    for (int i = 0; i < grades.Length; i++)
        if (grades[i] > max)
        {
            max = grades[i];
        }
    return max;
}
static int GetMinGrade (int[] grades)
{
    int min = 10;
    for (int i = 0; i < grades.Length; i++)
        if (grades[i] < min)
        {
        min = grades[i];
        }
    return min;
}
static void ShowAverageMaxMinGrade(int[] grades)
{
    float average = GetAverageGrade(grades);
    int max = GetMaxGrade(grades);
    int min = GetMinGrade(grades);
    Console.WriteLine("Average grade = " + average);
    Console.WriteLine("Max grade = " + max);
    Console.WriteLine("Min grade = " + min);
}
int[] ivanov = { 6, 8, 10, 8, 4, 7, 10 };
ShowAverageMaxMinGrade(ivanov);
int[] fedorov = { 2, 10, 8, 8, 6, 8, 10 };
ShowAverageMaxMinGrade(fedorov);
int[] mishin = { 8, 8, 9, 5, 4, 9, 9 };
ShowAverageMaxMinGrade(mishin);
int[] petrov = { 6, 9, 10, 5, 9, 7, 8 };
ShowAverageMaxMinGrade(petrov);
int[] sidorov = { 10, 8, 10, 10, 8, 10, 9 };
ShowAverageMaxMinGrade(sidorov);

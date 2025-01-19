// Número de provas
int examAssignments = 5;

// Nomes dos alunos
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Notas dos alunos
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Array para armazenar as notas do aluno atual
int[] studentScores = new int[10];

// Variável para armazenar a nota final do aluno em formato de letra
string currentStudentLetterGrade = "";

// Exibir o cabeçalho para as notas e médias
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

// Iterar sobre cada aluno
foreach (string name in studentNames)
{
    string currentStudent = name;

    // Atribuir as notas do aluno atual à variável studentScores
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;
        
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
        
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    
    else if (currentStudent == "Gregor")    
        studentScores = gregorScores;

    // Variáveis para armazenar a contagem de provas e trabalhos extras
    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    // Variáveis para armazenar a soma das notas das provas e dos trabalhos extras
    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    // Variáveis para armazenar as médias das notas
    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    // Iterar sobre as notas do aluno atual
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        // Somar as notas das provas
        if (gradedAssignments <= examAssignments)
        {
            sumExamScores = sumExamScores + score;
        }
        // Somar as notas dos trabalhos extras
        else
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    // Calcular a média das notas das provas
    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
    // Calcular a média das notas dos trabalhos extras
    currentStudentExtraCreditScore = gradedExtraCreditAssignments > 0 ? (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments : 0;

    // Calcular a nota final do aluno
    currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

    // Atribuir a nota final em formato de letra
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

    // Exibir as informações do aluno
    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}

// Manter a janela de saída aberta para visualizar os resultados
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

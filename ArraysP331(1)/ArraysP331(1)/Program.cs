//////////////////////////////////// TASK 1 ////////////////////////////////////////////////////////////////////
//Integer array-i hazır sort metodu istifadə etmədən artan sıra ilə sort etmək. (Bu tapşırıği internetdə araşdıraraq edin).
//Məsələn:
//arr = { 100,300,200,50}, 
//Nəticə: arr = { 50,100,200,300}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//burda hazir metodun arxa planda nece islediyini gostermeye calismisam 

//int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
//int temp = 0;

//for (int i = 0; i <= intArray.Length - 1; i++)
//{
//    for (int j = i + 1; j < intArray.Length; j++)
//    {
//        if (intArray[i] > intArray[j])
//        {
//            temp = intArray[i];
//            intArray[i] = intArray[j];
//            intArray[j] = temp;
//        }
//    }
//}
//foreach (var item in intArray)
//{
//    Console.WriteLine(item);
//}
//Console.ReadLine();

// hazir metod yolu ile:

//int[] myNumbers = { 5, 1, 8, 9 };
//Array.Sort(myNumbers);
//foreach (int i in myNumbers)
//{
//    Console.WriteLine(i);
//}

//////////////////////////////////// TASK 2 ////////////////////////////////////////////////////////////////////


//int[] arr = { 8, 2, 4, 6, 12 };

//int i = 0;
//int sum = 0;
//float average = 0.0F;

//for (i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}

//average = (float)sum / arr.Length;

//Console.WriteLine(average);

//floatdan istfade etmekde sebeb ededi ortani tapan zaman deqiq cavab cixarmasidir (float)sum bu setiri arasdirdim ve internetden goturdum cunki bu setr olmadan helede cavab deqiq gostermirdi float olaraq

//////////////////////////////////// TASK 3 ////////////////////////////////////////////////////////////////////

//int[] array = { 2, 4, 6, 8 };
//Array.Reverse(array);

//Console.WriteLine(String.Join(',', array));
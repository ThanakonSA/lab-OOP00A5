// See https://aka.ms/new-console-template for more information
Students student1 = new Students();
student1.name = "Sanruethai";
student1.weight = 55f;

Students student2 = new Students();
student2.name = "Natthawan";
student2.weight = 57f;

Students student3 = new Students();
student3.name = "Pitchakorn";
student3.weight = 60f;

Students student4 = new Students();
student4.name = "Witchaphon";
student4.weight = 70f;

Students student5 = new Students();
student4.name = "Phanuwat";
student4.weight = 60f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Weight avg of Student : " + avgWeight);
Console.WriteLine("weight high witchaphon : 70");
Console.WriteLine("weight low sanruethai : 55");
Console.WriteLine("Thanakon Sawangsunnoen 65350285-1");
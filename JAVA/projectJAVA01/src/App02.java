import java.text.NumberFormat;
import java.util.Arrays;
//import java.util.Scanner;

public class App02 {
    public static void main(String[] args) {
        System.out.println("Hello, World!");
        String message = " Hello\n \t\"World\" "  + " ! ! ";
        System.out.println(message.startsWith(" "));
        System.out.println(message.endsWith("!!"));
        System.out.println(message.length());
        System.out.println(message.indexOf("H"));
        System.out.println(message.toLowerCase());
        System.out.println(message);
        System.out.println(message.trim());

        //int [] numbers = new int [5];
        //numbers[0] = 1;
        //numbers[1] = 2;
        //numbers[2] = 3;

        int[] numbers ={2,3,5,1,4};
        System.out.println(numbers.length);
        System.out.println(Arrays.toString(numbers));
        Arrays.sort(numbers);
        System.out.println(Arrays.toString(numbers));

        int [][] nombor = { {1,2,3}, {4,5,6} };
        System.out.println(Arrays.deepToString(nombor));
        //system.out.println(message.replace( target: "!", replacement: "*"));

        int result1 = 10 + 3;
        System.out.println(result1);
        double result2  = (double)10 / (double)3;
        System.out.println(result2);

        int x =1;
        int y =x++;
        System.out.println(x);
        System.out.println(y);

        x += 2;
        System.out.println(x);

        // Implicit casting
        // byte converted to short converted to int converted to long converted to float converted to double
        short a = 1;
        int b = a + 2; 
        System.out.println(b);

        double c = 1.1;
        double d = c + 2; 
        System.out.println(d);

        double e = 1.1;
        double f = (int)e + 2; 
        System.out.println(f);

        String g = "1";
        int h = Integer.parseInt(g) +2;
        System.out.println(h);

        String i = "1.1";
        double j = Double.parseDouble(i) +2;
        System.out.println(j);

int k= Math.round(1.1F);
System.out.println(k);

int l = (int)Math.floor(1.1F);
System.out.println(l);

int m = (int)Math.ceil(1.1F);
System.out.println(m);

//int n = (int)Math.min(100,200);
//System.out.println(n);

//int o = (int)Math.max(100,200);
//System.out.println(o);

double p = Math.random();
System.out.println(p);

double q = Math.random() *100;
System.out.println(q);

int r = (int)(Math.random() *100);
System.out.println(r);

    //byte age = 35;
    //long viewsCount = 3_123_456_789L;
    //float price = 10.99F;
    //char letter ='A';
    //boolean isEligible = true;

    //import java.util.Date;
    //byte age = 30;
    //Date now = new Date ();
    //System.out.println(now);

    //import java.awt.Point;
    //Point point1 = new Point (x)
    //Point point2 = point1,
    //point1.x = 2;

double number = 1234567.8912;
NumberFormat currency = NumberFormat.getCurrencyInstance();
String s = currency.format (number);
System.out.println(s);

double nombbor = 0.7;
NumberFormat percent = NumberFormat.getPercentInstance();
String t = percent.format (nombbor);
System.out.println(t);

/*System.out.println("Age Game");
Scanner scanner1 = new Scanner(System.in);
System.out.print("Age: ");
byte age = scanner1.nextByte();
System.out.println("You are " + age);

System.out.println("Name Game");
Scanner scanner2 = new Scanner(System.in);
System.out.print("Name: ");
String name = scanner2.nextLine();
System.out.println("You are " + name);*/


int temp = 32 ;
if (temp > 30) {
	System.out.println("It is a hot day!");
	System.out.println("drink lots of water.");
} else if (temp > 20) {
	System.out.println("Its a NICE day.");
} else {
	System.out.println("Its a cold day ");
}

int income = 120_000;
boolean hasHighIncome;
if (income > 100000) {
    hasHighIncome = true; 
} else {
    hasHighIncome = false;
}
System.out.println(hasHighIncome);

int incomes = 120_000;
String className;
if (incomes > 100_00) {
    className = "First";
}
else
    className = "Economy";
System.out.println(className);

int gaji = 90_000;
String classNames = gaji > 100_000 ? "First Class" : "Economy";
System.out.println(classNames);

String role = "admin";
if (role == "admin") {
    System.out.println("You Are An Admin");
}   else if (role == "moderator") {
    System.out.println("You Are A Moderato");
} else
    System.out.println("You Are A Guess");

String roles = "moderator";
switch (roles) {
        case "admin":
        System.out.println(" You Are An Admin");
        break;
        case "moderator":
        System.out.println("You Are An Moderator");
        break;
        default:
        System.out.println(" You Are A Guess");}

/*Scanner scanner3 = new Scanner(System.in);
System.out.print("FizzBuzz Number: ");
int angka = scanner3.nextInt();
if (angka % 5 == 00 && angka % 3 == 0) {
    System.out.println("FizzBuzz");
}   else if (angka % 5 == 0) {
    System.out.println("Fizz");
}   else if (angka % 3== 0) {
    System.out.println("Buzz");}

for (int u = 1; u <= 5; u++){
    System.out.println("Hello World! " + u);}

System.out.println("Guess A Word To QUIT loop");
Scanner scanner4 = new Scanner(System.in);
String input1 = "";
while (!input1.equals("quit")){
    System.out.print("Input1: ");
    input1 = scanner4.next().toLowerCase();
    if (input1.equals("pass"))
        continue;
    if (input1.equals("quit"))
        break;
        System.out.println(input1);}

    String[] fruits = {"Apple", "Mango","Orange"};
    for (int v = 0; v < fruits.length; v++)
    System.out.print(fruits[v]);*/


}}

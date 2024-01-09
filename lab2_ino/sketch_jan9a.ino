String mySt1="";
String mySt2="";

void setup() {
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    mySt1 = Serial.readString();
    mySt2 = Serial.readString();

    int number1 = mySt1.toInt();
    int number2 = mySt2.toInt();
    
    int sumOfSquares = (number1 * number1) + (number2 * number2);

    Serial.print("Sum of squares: ");
    Serial.println(sumOfSquares);
  }
}

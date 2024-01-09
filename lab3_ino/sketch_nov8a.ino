#include <ArduinoJson.h>.
#include <Servo.h>. 

const int buzzerPin = 8; // Пін для підключення динаміка
unsigned long previousMillis = 0; // Зберігаємо час останнього оновлення

const int redPin = 3; // Пін для червоного кольору
const int greenPin = 5; // Пін для зеленого кольору
const int bluePin = 6; // Пін для синього кольору

const int trigPin = 10;
const int echoPin = 11;

// Change
bool buttonState = true; // поточний стан кнопки
int startAngle = 0;
int endAngle = 180;
long stereoTon = 500; // Інтервал між звуками 
int radarDelay = 60; // Затримка повороту

long duration;
int distance;
int stereoDuration = 16;

StaticJsonDocument<300> jsonDoc;

Servo myServo; 
void setup() {
 
  pinMode(trigPin, OUTPUT); 
  pinMode(echoPin, INPUT); 
  pinMode(buzzerPin, OUTPUT); 

  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
  //setColor(0, 255, 0);

  Serial.begin(9600);
  myServo.attach(12); 

}
void loop() {

  if (Serial.available() > 0) 
  {
    String jsonStr = Serial.readString();
    //delay(3000);
    deserializeJson(jsonDoc, jsonStr);
    //delay(3000);
    Serial.print("Parse JSON str: ");
    Serial.println(jsonStr);
    Serial.print("Parse JSON doc: ");
    Serial.println(jsonDoc.as<String>());

    startAngle = jsonDoc["rC"]["stA"];
    endAngle = jsonDoc["rC"]["endA"];
    buttonState = jsonDoc["rC"]["rW"];
    stereoTon = jsonDoc["rC"]["sI"];
    radarDelay = jsonDoc["rC"]["rD"];
    
  }

  if(buttonState)
  {
  for(int i=startAngle;i<=endAngle;i++){  
      myServo.write(i);
      delay(radarDelay);
      distance = calculateDistance();
      setColorForDistance(distance);
      Serial.print("Angle: ");
      Serial.print(i);
      Serial.print("  Distance: ");
      Serial.println(distance);
      unsigned long currentMillis = millis();
      if (distance > 0 && distance < 45) {
        //previousMillis = currentMillis; 
        tone(buzzerPin, stereoTon, stereoDuration); 
      }
  }
  
  // Repeats the previous lines from 165 to 15 degrees
  for(int i=endAngle;i>startAngle;i--) 
  { 
      myServo.write(i);
      delay(radarDelay);
      distance = calculateDistance();
      setColorForDistance(distance);
      Serial.print("Angle: ");
      Serial.print(i);
      Serial.print("  Distance: ");
      Serial.println(distance);
      unsigned long currentMillis = millis();
      if (distance > 0 && distance < 45) {
        //previousMillis = currentMillis; 
        tone(buzzerPin, stereoTon, stereoDuration); // tone(pin, frequency, duration)
      }
  }
  }
}

int calculateDistance(){ 
  digitalWrite(trigPin, LOW); 
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin, HIGH); 
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH); // Reads the echoPin, returns the sound wave travel time in microseconds
  distance= duration*0.034/2;
  return distance;
}
void setColor(int red, int green, int blue) {
  analogWrite(redPin, red);
  analogWrite(greenPin, green);
  analogWrite(bluePin, blue);
}
void setColorForDistance(int distance)
{
  if(distance <= 45 && distance > 30) {
    setColor(255,0,0);
  }
  else if(distance <= 30 && distance > 15) {
    setColor(0,0,255);
  }
  else if(distance <= 15 && distance > 0) {
    setColor(0,255,0);
  }
  else{
    setColor(0,0,0);
  }
}
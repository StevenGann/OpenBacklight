//============================================//
// Generic Arduino firmware for OpenBacklight //
//============================================//

int Speed = 100;
int RedPin = 6;
int GreenPin = 3;
int BluePin = 5;

int RedVal = 0;
int GreenVal = 0;
int BlueVal = 0;

void setup()
{
    pinMode(RedPin, OUTPUT);
    pinMode(GreenPin, OUTPUT);
    pinMode(BluePin, OUTPUT);
    
    Serial.begin(115200);
}

void loop() 
{
    readPacket();
    
    //Serial.println(String(Rval) + ", " + String(Gval) + ", " + String(Bval)); 
    
    delay(100);
}

void readPacket()
{
    while(Serial.available() > 0) //when there's information being received through serial go into this loop
    {
      int Rnew = Serial.parseInt(); //takes each value seperated by the commas and defines them to the four different values
      int Gnew = Serial.parseInt();
      int Bnew = Serial.parseInt();
      serialFlush(); //flushes any other values in the buffer
      
      FadeTo(Rnew, Gnew, Bnew, 1000);
    }

}

void FadeTo(int redTarget, int greenTarget, int blueTarget, int timeTarget)
{
  float redDelta = ((float)(redTarget - RedVal)) / ((float)timeTarget);
  float greenDelta = ((float)(greenTarget - GreenVal)) / ((float)timeTarget);
  float blueDelta = ((float)(blueTarget - BlueVal)) / ((float)timeTarget);
  
  //Serial.print("Deltas: ");
  //Serial.print(String(redDelta) + " ");
  //Serial.print(String(greenDelta) + " ");
  //Serial.print(String(blueDelta) + " ");
  //Serial.print("\n");
  
  float redNew = (float)RedVal;
  float greenNew = (float)GreenVal;
  float blueNew = (float)BlueVal;
  
  for (int i = 0; i < timeTarget; i++)
  {
    redNew += redDelta;
    greenNew += greenDelta;
    blueNew += blueDelta;
    
    //Serial.print("New values: ");
    //Serial.print(String(redNew) + " ");
    //Serial.print(String(greenNew) + " ");
    //Serial.print(String(blueNew) + " ");
    //Serial.print("\n");
    
    analogWrite(RedPin, (int)redNew);
    analogWrite(GreenPin, (int)greenNew);
    analogWrite(BluePin, (int)blueNew);
    
    delay(1);
  }
  
  RedVal = (int)redNew;
  GreenVal = (int)greenNew;
  BlueVal = (int)blueNew;
}

void serialFlush()
{
    while(Serial.available()>0) Serial.read(); 
    //Flushes any other values in the buffer
}

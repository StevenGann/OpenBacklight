//============================================//
// Generic Arduino firmware for OpenBacklight //
//============================================//

int Rpin = 9;
int Gpin = 10;
int Bpin = 11;

int Rval = 0;
int Gval = 0;
int Bval = 0;

void setup()
{
    pinMode(Rpin, OUTPUT);
    pinMode(Gpin, OUTPUT);
    pinMode(Bpin, OUTPUT);
    
    Serial.begin(9600);
}

void loop() 
{
    readPacket();
    
    analogWrite(Rpin, Rval);
    analogWrite(Gpin, Gval);
    analogWrite(Bpin, Bval);
    
    delay(100);
}

void readPacket()
{
    while(Serial.available() > 0) //when there's information being received through serial go into this loop
    {
      Rval = Serial.parseInt(); //takes each value seperated by the commas and defines them to the four different values
      Bval = Serial.parseInt();
      Gval = Serial.parseInt();
      serialFlush(); //flushes any other values in the buffer
  }
}

void serialFlush()
{
    while(Serial.available()>0) Serial.read(); 
    //Flushes any other values in the buffer
}

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
    
    Serial.begin(115200);
}

void loop() 
{
    readPacket();
    
    analogWrite(Rpin, Rval);
    analogWrite(Gpin, Gval);
    analogWrite(Bpin, Bval);
    
    Serial.println(String(Rval) + ", " + String(Gval) + ", " + String(Bval)); 
    
    delay(100);
}

void readPacket()
{
    int Rnew = -1;
    int Gnew = -1;
    int Bnew = -1;
    
    while(Serial.available() > 0) //when there's information being received through serial go into this loop
    {
      Rnew = Serial.parseInt(); //takes each value seperated by the commas and defines them to the four different values
      Bnew = Serial.parseInt();
      Gnew = Serial.parseInt();
      serialFlush(); //flushes any other values in the buffer
    }
    
    Serial.println(String(Rnew) + ", " + String(Gnew) + ", " + String(Bnew)); 
    
    if (Rnew >= 0 && Rnew <= 255 && Gnew >= 0 && Gnew <= 255 && Bnew >= 0 && Bnew <= 255)
        {
            Rval = Rnew;
            Gval = Gnew;
            Bval = Bnew;
        }
}

void serialFlush()
{
    while(Serial.available()>0) Serial.read(); 
    //Flushes any other values in the buffer
}

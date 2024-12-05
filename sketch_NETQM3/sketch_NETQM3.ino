// NeoPixel Ring simple sketch (c) 2013 Shae Erisson
// Released under the GPLv3 license to match the rest of the
// Adafruit NeoPixel library

#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
#include <avr/power.h> // Required for 16 MHz Adafruit Trinket
#include <EEPROM.h>
#endif

// Which pin on the Arduino is connected to the NeoPixels?
#define PIN        4 // On Trinket or Gemma, suggest changing this to 1

// How many NeoPixels are attached to the Arduino?
#define NUMPIXELS 50 // Popular NeoPixel ring size

// When setting up the NeoPixel library, we tell it how many pixels,
// and which pin to use to send signals. Note that for older NeoPixel
// strips you might need to change the third parameter -- see the
// strandtest example for more information on possible values.
Adafruit_NeoPixel pixels(NUMPIXELS, PIN, NEO_GRBW + NEO_KHZ800);

#define DELAYVAL 500 // Time (in milliseconds) to pause between pixel

//inputString
String inputString = "";

//Error
int errorR = 255;
int errorG = 0;
int errorB = 0;
int blinkmodeError = 1; 
int blinkmodeErrorSpeed = 0;

//Warning
int warningR = 255;
int warningG = 255;
int warningB = 0;
int blinkmodeWarning = 2; 
int blinkmodeWarningSpeed = 0;


//Check
int checkR = 0;
int checkG = 255;
int checkB = 0;
int blinkmodeCheck = 0; 
int blinkmodeCheckSpeed = 0;


//LightShow
int lightShow = 0;
int lightShowSpeed = 0;
int lightShowSpeedDelay = 0;

//BackgroundLight
int backgroundLight = 0;
int backgroundLightColor = 0;
int backgroundLightColorINT = 0;
int backgroundR = 0;
int backgroundG = 0;
int backgroundB = 0;

//brightness
int brightness = 255;

//count
int count = 1;

//blinkmode speeds
int fast = 200;
int slow = 350;

//splitComplete
bool string_complete = false;
bool splitComplete = false;
bool dataReceived = false;

void setup(){
  Serial.begin(9600);
  inputString.reserve(200);
  #if defined(__AVR_ATtiny85__) && (F_CPU == 16000000)
  clock_prescale_set(clock_div_1);
  strip.begin();
  #endif
  // END of Trinket-specific code.

  pixels.begin(); // INITIALIZE NeoPixel strip object (REQUIRED)
  pixels.setBrightness(brightness);
  pixels.fill(pixels.Color(0,0,0,0));
  pixels.show();

  readFromEEPROM();
  setLightShowSpeed();
  setBlinkModeSpeed();
// Definieren der Eingänge

pinMode (12, INPUT);
pinMode (11, INPUT);
pinMode (10, INPUT);
}

void loop(){
  if(Serial.available()) {
    serialEvent();
    setLightShowSpeed();
    setBlinkModeSpeed();
  }
  if(string_complete = true) {    //main loop
    if(lightShow == 1) {                          //LIGHTSHOW
      for(int i = 0; i < 2; i++) {
        pixels.fill(pixels.Color(errorR, errorG, errorB, 0));
        pixels.show();
        delay(lightShowSpeedDelay);
        pixels.fill(pixels.Color(warningR, warningG, warningB, 0));
        pixels.show();
        delay(lightShowSpeedDelay);
        pixels.fill(pixels.Color(checkR, checkG, checkB, 0));
        pixels.show();
        delay(lightShowSpeedDelay);
        lightShow = -1;
      }
    }
    
    if(backgroundLight == 1) {        //BACKGROUNDLIGHT
      switch(backgroundLightColor) {
        case 1:   //white
          pixels.fill(pixels.Color(0,0,0,255));
          pixels.show();
          break;
        case 2:   //blue
          pixels.fill(pixels.Color(128,255,255,0));
          pixels.show();
          break;
        case 3:   //custom
          pixels.fill(pixels.Color(backgroundR,backgroundG,backgroundB,0));
          pixels.show();
          break;
      }
    }
    else {
      pixels.fill(pixels.Color(0,0,0,0));
      pixels.show();  
    }

    while(digitalRead(12) == HIGH){
      Serial.println("1");
      pixels.fill(pixels.Color(errorR, errorG, errorB, 0));
      pixels.show();
      delay(blinkmodeErrorSpeed);
      if(blinkmodeError != 0) {
        pixels.fill(pixels.Color(0,0,0,0));
        pixels.show();
        delay(blinkmodeErrorSpeed);
      }
    }
    while(digitalRead(11) == HIGH){
      Serial.println("1");
      pixels.fill(pixels.Color(warningR, warningG, warningB, 0));
      pixels.show();
      delay(blinkmodeWarningSpeed);
      if(blinkmodeWarning != 0) {
        pixels.fill(pixels.Color(0,0,0,0));
        pixels.show();
        delay(blinkmodeWarningSpeed);
      }
    }
    while(digitalRead(10) == HIGH){
      Serial.println("1");
      pixels.fill(pixels.Color(checkR, checkG, checkB, 0));
      pixels.show();
      delay(blinkmodeCheckSpeed);
      if(blinkmodeCheck != 0) {
        pixels.fill(pixels.Color(0,0,0,0));
        pixels.show();
        delay(blinkmodeCheckSpeed);
      }
    }

    
    
  }
} 
void setLightShowSpeed()
{
  if(lightShowSpeed == 1){
    lightShowSpeedDelay = 400;
  }
  else if(lightShowSpeed == 2) {
    lightShowSpeedDelay = 500;  
  }
  else {
    lightShowSpeedDelay = 600;
  }
}
void setBlinkModeSpeed() {
  if(blinkmodeError == 1){
    blinkmodeErrorSpeed = 250;
  } else if(blinkmodeError == 2) {
    blinkmodeErrorSpeed = 400;
  }

  if(blinkmodeWarning == 1) {
    blinkmodeWarningSpeed = 200;
  } else if(blinkmodeWarning == 2) {
    blinkmodeWarningSpeed = 400;
  }

  if(blinkmodeCheck == 1) {
    blinkmodeCheckSpeed = 250;
  } else if(blinkmodeCheck == 2) {
    blinkmodeCheckSpeed = 400;
  }
}

void serialEvent(){
  inputString = "";
  while(Serial.available()) {
    delay(50);
    //get the new byte:
    char inChar = (char)Serial.read();
    //add it to the input String;
    inputString += inChar;
    dataReceived = true;
    splitComplete = false;
  }
  if(dataReceived == true) {
    splitString(inputString);
  }
}

void splitString(String inputString) {
  count = 1;
  int index = 0;
  int startIndex = 0;
  int endIndex = 0;
  String temp = "";
  //split the datas
    while(splitComplete == false)
    {
     //Serial.println(inputString);
      index = inputString.indexOf('/');
      endIndex = inputString.length();
      temp = inputString.substring(index+1, endIndex);
  
      switch(count) {
        case 1:
          errorR = inputString.substring(0,index).toInt();  //error color red
          EEPROM.write(count, errorR);
          //Serial.println(errorR);
        case 2:
          errorG = inputString.substring(0,index).toInt();  //error color green
          EEPROM.write(count, errorG);
          //Serial.println(errorG);
          break;
        case 3:
          errorB = inputString.substring(0, index).toInt(); //error color blue
          EEPROM.write(count, errorB);
          //Serial.println(errorB);
          break;
        case 4:
          warningR = inputString.substring(0, index).toInt(); //warning color red
          EEPROM.write(count, warningR);
          //Serial.println(warningR);
          break;
        case 5:
          warningG = inputString.substring(0, index).toInt(); //warning color green
          EEPROM.write(count, warningG);
          //Serial.println(warningG);
          break;
        case 6:
          warningB = inputString.substring(0, index).toInt(); //warning color blue
          EEPROM.write(count, warningB);
          //Serial.println(warningB);
          break;
        case 7:
          checkR= inputString.substring(0, index).toInt(); //check color red
          EEPROM.write(count, checkR);
          //Serial.println(checkR);
          break;
        case 8:
          checkG = inputString.substring(0, index).toInt(); //check color green
          EEPROM.write(count, checkG);
          //Serial.println(checkG);
          break;
        case 9:
          checkB = inputString.substring(0, index).toInt(); // check color blue
          EEPROM.write(count, checkB);
          //Serial.println(checkB);
          break;
        case 10:
          blinkmodeError = inputString.substring(0, index).toInt(); //blink mode error
          EEPROM.write(count, blinkmodeError);
          //Serial.println(blinkmodeError);
          break;  
        case 11:
          blinkmodeWarning = inputString.substring(0, index).toInt(); //blink mode warning
          EEPROM.write(count, blinkmodeWarning);
          //Serial.println(blinkmodeWarning);
          break;
        case 12:
          blinkmodeCheck = inputString.substring(0, index).toInt(); //blink mode check
          EEPROM.write(count, blinkmodeCheck);
          //Serial.println(blinkmodeCheck);
          break;
        case 13:
          lightShow = inputString.substring(0, index).toInt(); //start-lightshow
          EEPROM.write(count, lightShow);
          //Serial.println(lightShow);
          break;
        case 14:
          lightShowSpeed = inputString.substring(0, index).toInt(); //lightshow speed
          EEPROM.write(count, lightShowSpeed);
          //Serial.println(lightShowSpeed);
          break;
        case 15:
          backgroundLight = inputString.substring(0, index).toInt(); //background-Light
          EEPROM.write(count, backgroundLight);
          //Serial.println(backgroundLight);
          break;
        case 16:
          backgroundLightColor = inputString.substring(0, index).toInt(); //background-light color
          EEPROM.write(count, backgroundLightColor);
          //Serial.println(backgroundLightColor);
          break;
        case 17:
          backgroundR = inputString.substring(0, index).toInt(); //background-light custom red
          EEPROM.write(count, backgroundR);
          //Serial.println(backgroundR);
          break;
        case 18:
          backgroundG = inputString.substring(0, index).toInt(); //background-light custom green
          EEPROM.write(count, backgroundG);
          //Serial.println(backgroundG);
          break;
        case 19:
          backgroundB = inputString.substring(0, index).toInt(); //background-light custom blue
          EEPROM.write(count, backgroundB);
          //Serial.println(backgroundB);
          splitComplete = true;
          dataReceived = false;
          string_complete = true;
          break;          
      }
      delay(30);
      Serial.println(inputString);
      inputString = temp;
      count++;
  }
}

void readFromEEPROM() {
  if(EEPROM.length() > 0) {
    for(int i = 0; i < 20; i++) {
      switch(i) {
        case 1:
          errorR = EEPROM.read(i);
          break;
        case 2:
          errorG = EEPROM.read(i);
          break;
        case 3:
          errorB = EEPROM.read(i);
          break;
        case 4:
          warningR = EEPROM.read(i);
          break;
        case 5:
          warningG = EEPROM.read(i);
          break;
        case 6:
          warningB = EEPROM.read(i);
          break;
        case 7:
          checkR = EEPROM.read(i);
          break;
        case 8:
          checkG = EEPROM.read(i);
          break;
        case 9:
          checkB = EEPROM.read(i);
          break;
        case 10:
          blinkmodeError = EEPROM.read(i);
          break;
        case 11:
          blinkmodeWarning = EEPROM.read(i);
          break;
        case 12:
          blinkmodeCheck = EEPROM.read(i);
          break;
        case 13:
          lightShow = EEPROM.read(i);
          break;
        case 14:
          lightShowSpeed = EEPROM.read(i);
          break;
        case 15:
          backgroundLight = EEPROM.read(i);
          break;
        case 16:
          backgroundLightColor = EEPROM.read(i);
          break;
        case 17:
        backgroundR = EEPROM.read(i);
          break;
        case 18:
          backgroundG = EEPROM.read(i);
          break;
        case 19:
          backgroundB = EEPROM.read(i);
          string_complete = true;
          break;
      }
      //delay(2000);
      Serial.println("count:");
      Serial.println(EEPROM.read(i));
    }
  }
}

# Import sleeping, ended up not using this because any sleeps harshly limits potential.
from time import sleep


# Establish global variables to use in the function later, useful if I decide to add other funcs later.
global numbertodo
global numbertodoorig
global highestnum
global mathcount
global highestnumsofar
global record

def math(numtostart):

    # Set initial values.
    mathcount = 0
    numbertodo = numtostart
    numbertodoorig = numbertodo
    highestnum = numbertodo
    highestnumsofar = 0
    record = 0

    # Make new line in console to look nice (\n was making 2 lines).
    print("")

    # Use w (write) mode to overwrite any file thats there, or create it if it doesn't exist.
    logfile = open("C:\Program Files\Collatz Conjecture\Collatz Conjecture Log.txt","w")  
    logfile.write("")
    logfile.close

    # Avoid arithmetic operation overflow due to size exceeding max of 64 bit signed int.
    while int(numbertodoorig) < 9223372036854775807:
     
    # Log highest numbers seen per number tried and in general.
     if int(numbertodo) > int(highestnum): 
       if int(numbertodo) > int(highestnumsofar):
           highestnumsofar = numbertodo
       highestnum = numbertodo

       # Checking if number is odd or even and acting accordingly.
     if (int(numbertodo) % 2) == 0:  
        numbertodo = int(numbertodo) / 2
        mathcount = int(mathcount) + 1
     else:  
        numbertodo = (int(numbertodo) * 3) + 1
        mathcount = int(mathcount) + 1
        
        # If the number hits 1, it's finished and log that to files and console output.
     if numbertodo == 1:
        print(str(numbertodoorig) + ": " + str(mathcount) + ", " + str(highestnum) + "\n")
        logfile = open("C:\Program Files\Collatz Conjecture\Collatz Conjecture Log.txt","a")  
        logfile.write(str(numbertodoorig) + ": " + str(mathcount) + ", " + str(highestnum) + "\n")
        logfile.close
        mathcount = 0
        numbertodo = int(numbertodoorig) + 1
        numbertodoorig = int(numbertodo)
        highestnum = numbertodoorig
        if int(highestnumsofar) > int(record):
            print("New record! " + str(highestnumsofar) + "\n")
            logfile = open("C:\Program Files\Collatz Conjecture\Collatz Conjecture Log.txt","a")  
            logfile.write("New record! " + str(highestnumsofar) + "\n")
            logfile.close
            logfile = open("C:\Program Files\Collatz Conjecture\Collatz Conjecture Record Log.txt","w")  
            logfile.write("Current record is " + str(highestnumsofar))
            logfile.close
            record = highestnumsofar

        # Fairly self explanatory, just asking where to start
math(input("What number should the program start at?\n"))
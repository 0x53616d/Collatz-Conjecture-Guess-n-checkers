from time import sleep

global Mathing
global numbertodo
global numbertodoorig
global highestnum
global mathcount
global highestnumsofar
global record

def math(numtostart):
    numbertodo = numtostart
    numbertodoorig = numbertodo
    highestnum = numbertodo
    highestnumsofar = 0
    record = 0
    print("")
    logfile = open("E:\Dextop\stupid\Collatz Conjecture Log.txt","w")  
    logfile.write("")
    logfile.close

    while int(numbertodoorig) < 9223372036854775807:
     if int(numbertodo) > int(highestnum): 
       if int(numbertodo) > int(highestnumsofar):
           highestnumsofar = numbertodo
       highestnum = numbertodo

     if (int(numbertodo) % 2) == 0:  
        numbertodo = int(numbertodo) / 2
     else:  
        numbertodo = (int(numbertodo) * 3) + 1
        
     if numbertodo == 1:
        print(str(numbertodoorig) + ": " + str(highestnum) + "\n")
        logfile = open("E:\Dextop\stupid\Collatz Conjecture Log.txt","a")  
        logfile.write(str(numbertodoorig) + ": " + str(highestnum) + "\n")
        logfile.close
        numbertodo = int(numbertodoorig) + 1
        numbertodoorig = int(numbertodo)
        highestnum = numbertodoorig
        if int(highestnumsofar) > int(record):
            print("New record! " + str(highestnumsofar) + "\n")
            logfile = open("E:\Dextop\stupid\Collatz Conjecture Log.txt","a")  
            logfile.write("New record! " + str(highestnumsofar) + "\n")
            logfile.close
            logfile = open("E:\Dextop\stupid\Collatz Conjecture Log Records.txt","w")  
            logfile.write("Current record is " + str(highestnumsofar))
            logfile.close
            record = highestnumsofar


math(input("What number would you like to start at?\n"))
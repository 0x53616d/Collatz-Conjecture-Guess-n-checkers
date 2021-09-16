# Wrote this app in python because the VB one was inefficient and I assumed python would be faster. This app is basically useless so don't think you're making any useful mathematical contribution or anything of the sort haha. Thanks for checking out my code, feel free to modify it, make a pull request, submit an issue, or do basically whatever you want with this. just don't be a dick, and don't sell this for any reason. also don't sell earlier versions of this app for any reasons. Thank you! Have fun tinkering with my code, or just reading.

# Import sleeping, ended up not using this anyway, because any sleeps harshly limit potential.
from time import sleep


# Establish global variables to use in the function later, useful if I decide to add other funcs later.
global numbertodo
global numbertodoorig
global highestnum
global mathcount
global highestnumsofar
global record
# May implement threading later down the line but just seems unnecessary for now. This app isn't really maaking any progress on the issue anyway.

def math(numtostart):

    # Set initial values.
    mathcount = 0
    numbertodo = numtostart
    numbertodoorig = numbertodo
    highestnum = numbertodo
    highestnumsofar = 0
    record = 0

    # Make new line in console to look nice (\n was making 2 lines, this worked fine so whatever lol a long as it works I guess).
    print("")

    # Use w (write) mode to overwrite any file thats there, or create it if it doesn't exist.
    logfile = open("C:\Program Files\Collatz Conjecture\Collatz Conjecture Log.txt","w")  
    logfile.write("")
    logfile.close

    # Avoid arithmetic operation overflow due to size exceeding max of 64 bit signed int (Again, this app isn't really making any progress on this issue, as all numbers to 2^86 have been checked against this.).
    while int(numbertodoorig) < 9223372036854775807:
     
    # Log highest numbers seen per number tried and in general.
     if int(numbertodo) > int(highestnum): 
       if int(numbertodo) > int(highestnumsofar):
           highestnumsofar = numbertodo
       highestnum = numbertodo

       # Checking if number is odd or even and acting accordingly. This is the function that handles all of the actual math operation, the conjecture implementation.
     if (int(numbertodo) % 2) == 0:  
        numbertodo = int(numbertodo) / 2
        mathcount = int(mathcount) + 1
     else:  
        numbertodo = (int(numbertodo) * 3) + 1
        mathcount = int(mathcount) + 1
        
        # If the number being attempted eventually falls down to 1, it's finished and the app logs that to files and console output.
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
            logfile = open("C:\Program Files\Collatz Conjecture\Collatz Conjecture Record Log.txt","w")  # Open in w only mode so as to remove the current contents without having to delete the file every time.
            logfile.write("Current record is " + str(highestnumsofar))
            logfile.close
            record = highestnumsofar

        # Fairly self explanatory, just asking where to start.
math(input("What number should the program start at?\n"))
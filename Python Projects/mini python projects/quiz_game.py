print("Welcome to my chemistry quiz!")

playing = input("Do you want to play? ")

if playing != "yes":
    quit()

print("Okay! Let`s play :) ")
score = 0

answer = input("What is the chemical symbol for the element gold? ")
if answer.lower == "Au":
    print('Correct!')
    score += 1
else:
    print("Incorrect!")

answer = input("What is the chemical formula for water? ")
if answer.lower == "H2O":
    print('Correct!')
    score += 1
else:
    print("Incorrect!")
    
answer = input("What is the chemical name for baking soda? ")
if answer.lower == "Sodium bicarbonate":
    print('Correct!')
    score += 1
else:
    print("Incorrect!")
    

answer = input("What is pH? ")
if answer.lower == "measures acidity.":
    print('Correct!')
    score += 1
else:
    print("Incorrect!")
    
print("You got " + str(score) + "questions correct!")
print("You got " + str((score / 4) * 100) + "%.")

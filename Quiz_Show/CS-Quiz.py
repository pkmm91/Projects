print ("")
print ("Are you ready? then, Let's start")
print ""
print ""
print ""
print "Before playing the quiz , Let's check your level"
s = raw_input("Enter your name: ")
print "\n"
print "Level test starts........"
print "\n"
correct_answer , wrong_answer = 0 , 0
print "Just write 1 , 2 , 3 or 4 as your response\n"
print "1. Two main measures for the efficiency of an algorithm are"
print "a. Processor and memory"
print "b. Complexity and capacity"
print "c. Time and space"
print "d. Data and space\n"
r1 = input("Enter your answer: ")
if ( r1 == 3):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "2. The time factor when determining the efficiency of algorithm is measured by"
print "a. Counting microseconds "
print "b. Counting the number of key operations"
print "c. Counting the number of statements"
print "d. Counting the kilobytes of algorithm\n"
r2 = input("Enter your answer: ")
if (r2 == 2):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "3. The complexity of Bubble sort algorithm is "
print "a. O(n) "
print "b. O(log n)"
print "c. O(n2)"
print "d. O(n log n)\n"
r3 = input("Enter your answer: ")
if (r3 == 3):
    correct_answer +=1
else:
    wrong_answer +=1


print "\n"

print "4. Which of the following case does not exist in complexity theory?"
print "a. Best case "
print "b. Worst case"
print "c. Average case"
print "d. Null case\n"
r4 = input("Enter your answer: ")
if (r4 == 4):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "5. The Worst case occur in linear search algorithm when "
print "a. Item is somewhere in the middle of the array. "
print "b. Item is not in the array at all."
print "c. Item is the last element in the array."
print "d. Item is the last element in the array or is not there at all\n"
r5 = input("Enter your answer: ")
if (r5 == 4):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "6. Arrays are best data structures"
print "a. for relatively permanent collections of data "
print "b. for the size of the structure and the data in the structure are constantly changing"
print "c. for both of above situation"
print "d. for none of above situation\n"
r6 = input("Enter your answer: ")
if (r6 == 2):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "7. Which of the following data structure is linear data structure?"
print "a. Trees "
print "b. Graphs"
print "c. Arrays"
print "d. None of above\n"
r7 = input("Enter your answer: ")
if (r7 == 3):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "8. The operation of processing each element in the list is known as"
print "a. Sorting "
print "b. Merging"
print "c. Inserting"
print "d. Traversal\n"
r8 = input("Enter your answer: ")
if (r8 == 4):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "9. The indirect change of the values of a variable in one module by another module is called"
print "a. Internal change "
print "b. Inter-module change"
print "c. Side effect"
print "d. Side-module update\n"
r9 = input("Enter your answer: ")
if (r9 == 3):
    correct_answer +=1
else:
    wrong_answer +=1


print "\n"

print "10. Each array declaration need not give, implicitly or explicitly, the information about"
print "a. The name of array"
print "b. The data type of array"
print "c. The first data from the set to be stored"
print "d. The index set of the array\n"
r10 = input("Enter your answer: ")
if (r10 == 3):
    correct_answer +=1
else:
    wrong_answer +=1

print "\n"

print "%s result"%(s)
print "Correct Answer: %d"%(correct_answer)
print "Wrong Answer: %d"%(wrong_answer)
if (correct_answer <= 5):
    print "Begginer\n"
elif (correct_answer > 5 and correct_answer <= 7):
    print "Intermediate\n"
else:
    print "Advance\n"

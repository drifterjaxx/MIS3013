#Create a sequence of integers between 10 and 50. 
#Check each of these numbers if it is an even number. 
#If it is an even number, skip to the next number; if it’s an odd number, convert it to a string.
#Concatenate all the strings together into a single piece of string, which is separated by ‘,’
#Print out the intermediate result for each loop
#Also, check the length of the concatenated string. When the length of this concatenated string reaches 30, stop the loop process.
#Make sure to use for, continue, break, and other keywords when necessary

#Create a sequence of integers between 10 and 50.
sequence = list(range(10, 51))

#Check each of these numbers if it is an even number.
#If it is an even number, skip to the next number; if it’s an odd number, convert it to a string.
#Concatenate all the strings together into a single piece of string, which is separated by ‘,’
#Print out the intermediate result for each loop
#Also, check the length of the concatenated string. When the length of this concatenated string reaches 30, stop the loop process.
concatenated_string = ''
for number in sequence:
    if number % 2 == 0:
        continue
    else:
        concatenated_string += str(number) + ','
        print(concatenated_string)
        if len(concatenated_string) >= 30:
            break 
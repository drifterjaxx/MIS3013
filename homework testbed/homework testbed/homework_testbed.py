#this program reads a .csv file and stores the data in a dataframe.
#It the splits the table vertically into 3 tables, and use pd.concat to concatenate the tables back together.
#The program will split the table horizontally into two tables (left and right) with a common key column
##The program will filter out some rows from the first table, then from the second table, and combine the two tables back together 4 times.
#Each time uses one of the options: how=’left’, how=’right’, how=’inner’, how=’outer’.

import pandas as pd
import numpy as np
import random

#read the csv file
sli = pd.read_csv('Sloan_Inventory.csv')

#split the table vertically into 3 tables
sli1 = sli.iloc[:,0:5]
sli2 = sli.iloc[:,5:10]
sli3 = sli.iloc[:,10:15]

#concatenate the tables back together
sli_concat = pd.concat([sli1,sli2,sli3], axis=0)

#split the table horizontally into two tables (left and right) with a common key column
sli_left = sli.iloc[:,0:5]
sli_right = sli.iloc[:,5:15]

#filter out some rows from the first table
sli_left = sli_left[sli_left['Quantity'] > 10]

#filter out some rows from the second table
sli_right = sli_right[sli_right['Price'] > 100]

#combine the two tables back together 4 times
sli_left_right = pd.merge(sli_left,sli_right, on='ProductID', how='left')
sli_left_right2 = pd.merge(sli_left,sli_right, on='ProductID', how='right')
sli_left_right3 = pd.merge(sli_left,sli_right, on='ProductID', how='inner')
sli_left_right4 = pd.merge(sli_left,sli_right, on='ProductID', how='outer')


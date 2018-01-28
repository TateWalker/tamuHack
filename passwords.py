# passwords.py
import random
from colour import Color
import os.path
import csv

class pw():
	def __init__(self):
		self.fake = 0

	def randUp(self,s):
		def randupper(c):
			return random.random() > 0.5 and c.upper() or c
		return ''.join(map(randupper, s))

	def formPass(self,color,base):
		passwordBase = str(base)
		passwordBase = self.randUp(passwordBase)
		color = Color(color)
		hexColor = color.hex[1:8]
		colorSplit = [x for x in hexColor]
		passSplit = [x for x in passwordBase]

		newPassword = (colorSplit + passSplit)
		random.shuffle(newPassword)
		return ''.join(newPassword)

	def fetchPass(self,site):
		write_file = 'pwStorage.csv'
		csv_file = csv.reader(open(write_file, "r"))
		for row in csv_file:
			if site == row[0]:
				return(row[1])

	def savePass(self,site,password):
		cwd = os.getcwd()
		write_file = 'pwStorage.csv'
		if os.path.isfile(cwd+'/'+write_file): appender = 'a'
		else: appender = 'w'

		with open(write_file, appender) as output:
			if appender == 'w':	#creates new file with header
				output.write("Site, Password\n" + site + ',' + password + "\n")
			else:	#appends to csv file
				update = False
				r = csv.reader(open(write_file))
				lines = [l for l in r]
				for line in lines:	#check if website is already present
					if site == line[0]:
						update = True
						print("here")
						line[1] = password
						writer = csv.writer(open(write_file, 'w'))
						writer.writerows(lines)
				if update == False: 
					print("HERE")
					output.write(site + ',' + password + "\n")




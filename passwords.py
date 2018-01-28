# passwords.py
import random
from colour import Color
import os.path


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


	def savePass(self,site,password):
		cwd = os.getcwd()
		write_file = 'pwStorage.csv'
		if os.path.isfile(cwd+'/'+write_file): appender = 'a'
		else: appender = 'w'

		with open(write_file, appender) as output:
			if appender == 'w':
				output.write("Site, Password\n" + site + ',' + password + "\n")
			else: output.write(site + ',' + password + "\n")




import random
from tkinter import *
from tkinter import font
# from colors import COLORS1, COLORS
from colour import Color


class pw():
	def __init__(self):
		self.fake = 0
	
	def getCol(self):
		done = False
		while not done:
			color = str(input("Enter color\n"))
			try:
				if color == '':
					raise ValueError('Empty color.')
				else:
					c = Color(color)
					done = True
				
			except (ValueError) as e:
				print("That color doesn't exist, please try again.\n")	
		return c.hex


	def gen_pw(self):
		self.password_entry = input("Enter password base\n")
		self.new_pw = self.password_entry
		self.hex_color = self.getCol()[1:8]
		self.color_split = [x for x in self.hex_color]
		self.pwd_split = [x for x in self.new_pw]
		self.new_pw = (self.color_split + self.pwd_split)
		random.shuffle(self.new_pw)
		return ''.join(self.new_pw)



passw = pw()
stop = False

import os.path
import csv
cwd = os.getcwd()
write_file = 'pwStorage.csv'
if os.path.isfile(cwd+'/'+write_file):
	appender = 'a'
else:
	appender = 'w'

from time import sleep
import sys


def save_website(website):
	return {'password': 'somepass', 'username': ''}

while(stop == False):
	with open(write_file, appender) as output:
		if appender == 'w':
			output.write("Site, Password\n")
			done = False
			while not done:
				site = input("What is the website?\n")
				try:
					if site == '':
						raise ValueError('empty website')
					else:
						done = True
				except ValueError as e:
					print("Please input a website")
			output.write(site+','+passw.gen_pw()+"\n")
		else:
			print("Type \"Q\" to quit")
			done = False
			while not done:
				# site = input("What is the website?\n")
				site = str(serv.getWeb())
				try:
					if site == '':
						raise ValueError('empty website')
					elif (site == "Q"):
						sys.exit()
					else:
						done = True
				except ValueError as e:
					print("Please input a website")
			output.write(site+','+str(passw.gen_pw())+"\n")
			print("Password created!")
			sleep(1)
			print(chr(27) + "[2J")




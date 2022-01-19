from tkinter import *
root = Tk()
root.geometry("500x300")

def getvalue ():
    print ("Accepted")

#Heading
    Label (root, text="Python Registration Form", font="a 15 bold").grid(row=0, column=3)

#Field Nanmes
name = Label (root, text="First Name")
last = Label (root, text="Last Name")
phone = Label (root, text="Phone")
gender = Label (root, text="Gender")
email = Label (root, text="Email")

#Packing Fields
name.grid(row=1, column=2)
last.grid(row=2, column=2)
phone.grid(row=3, column=2)
gender.grid(row=4, column=2)
email.grid(row=5, column=2)

# Variable For Storing Data
namevalue = StringVar
lastvalue = StringVar
phonevalue = StringVar
gendervalue = StringVar
emailvalue = StringVar
checkvalue = IntVar

# Create Entry Fields
nameentry = Entry (root, textvariable = namevalue)
lastentry = Entry (root, textvariable = lastvalue)
phoneentry = Entry (root, textvariable = phonevalue)
genderentry = Entry (root, textvariable = gendervalue)
emailentry = Entry (root, textvariable = emailvalue)

#Packing Entry Fields
nameentry.grid(row=1, column=3)
lastentry.grid(row=2, column=3)
phoneentry.grid(row=3, column=3)
genderentry.grid(row=4, column=3)
emailentry.grid(row=5, column=3)

#Creating Checkbox
checkbutton =Checkbutton(text = "Rememeber Me ?",  variable = checkvalue)
checkbutton.grid (row =6, column =3 )

#Submit Button
Button(text="Submit", command = getvalue).grid(row=7, column =3)

root.mainloop()
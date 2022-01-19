from tkinter import *
from tkinter.ttk import *
import time

root = Tk()
root.title("Stopwatch")
root.geometry("240x100")
root.configure(bg="#06354A")

second = 0
minute = 0
hour = 0
stop = 0

def start():
    global second, minute, hour
    time.sleep(1)
    second +=1
    if second == 60:
        second = 0
        minute += 1
    if minute == 60:
        minute = 0
        hour += 1
    if stop == 0:
        label = Label(root, text=f"{hour}:{minute}:{second}")
        label.after(300, start)
        label.place(x=100, y=60)
        
def stop_watch():
    global stop
    stop = 1
    
start_button = Button(root, text="START", command=start).place(x=20, y=20)
stop_button = Button(root, text="STOP", command=stop_watch).place(x=120, y=20)

root.mainloop()
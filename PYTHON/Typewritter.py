import sys
import time
import os

message = 'Hello World, nice to meet you. \n'
for char in message:
    sys.stdout.write(char)
    sys.stdout.flush()
    time.sleep(0.1)

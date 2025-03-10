import tkinter as tk
from datetime import datetime, timedelta

def update_countdown():
    remaining_time = target_date - datetime.now()
    if remaining_time.total_seconds() <= 0:
        countdown_label.config(text="Countdown finished!", fg="green")
    else:
        days = remaining_time.days
        hours, remainder = divmod(remaining_time.seconds, 3600)
        minutes, seconds = divmod(remainder, 60)
        countdown_label.config(text=f"{days} days, {hours} hours, {minutes} minutes, {seconds} seconds")
        root.after(1000, update_countdown)  # Update every second

# Set the target date (365 days from now)
target_date = datetime.now() + timedelta(days=668)

# Create the main window
root = tk.Tk()
root.title("Countdown Timer")
root.geometry("400x200")



root.title("Countdown to Graduation: Completing My Bachelor's Degree")
countdown_label = tk.Label(root, text="Time Left to Finish My Bachelor's Degree", font=("Arial", 20))
countdown_label.pack(expand=True)

# Add a label for the countdown
countdown_label = tk.Label(root, text="", font=("Arial", 24))
countdown_label.pack(expand=True)


# Start the countdown
update_countdown()

# Run the application
root.mainloop()
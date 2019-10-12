class Joke:
    id = int(-1)                     # user_id
    pseudo = str("")                 # user_pseudo
    experience = int(0)              # user_experience
    joke = str("")                   # joke
    joke_date = ""                   # joke_date
    nickname = str("")               # nickname in the server discord
    avatar = str("")                 # url avatar of the user

    def __init__(self):
        print("create object")


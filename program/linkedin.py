from linkedin_scraper import Person, actions
from selenium import webdriver

driver = webdriver.Chrome("/Application/Google Chrome.app")
email = "*****"
password = "*****"
actions.login(driver, email, password) # if email and password isnt given, it'll prompt in terminal
person = Person("https://www.linkedin.com/in/aymerickmichelet", driver=driver)

print(person.scrape())


# import time
# from selenium import webdriver
# from selenium.webdriver.chrome.service import Service

# service = Service('/Applications/Google Chrome.app')
# service.start()
# # driver = webdriver.Remote(service.service_url)
# # driver.get('http://www.google.com/');
# # time.sleep(5) # Let the user actually see something!
# # driver.quit()

# https://realtime.www.linkedin.com/realtime.connect

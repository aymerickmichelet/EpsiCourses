from requests import get
from bs4 import BeautifulSoup

url = "https://www.linkedin.com/in/aymerickmichelet/"
url = "https://www.amazon.fr/Logitech-Lightspeed-Microphone-Surround-Coussinets/dp/B07W5JKB8Z/?_encoding=UTF8&pd_rd_w=mBMxn&pf_rd_p=ea965fe3-c780-4ca9-9025-f06840fe33f1&pf_rd_r=55YCE5A80RS291ZJDAGC&pd_rd_r=64c14dab-77a1-49ef-bb4c-255490f0ed7d&pd_rd_wg=MqDsT&ref_=pd_gw_ci_mcx_mr_hp_d"
url = "https://www.linkedin.com/litms/api/metadata/user"

headers = {"USER-Agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 11_2_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.82 Safari/537.36"}


def avaibility():
    page = get(url, headers=headers)
    soup = BeautifulSoup(page.content, "html.parser")
    # name = soup.find(classmethod="inline t-24 t-black t-normal break-words").get_text().strip()
    print(soup)



avaibility()
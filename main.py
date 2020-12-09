# -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-#
#                                                                       #
#                                                                       #
#   $$$$$$\  $$\   $$\ $$$$$$\$$$$\  $$$$$$$\  $$$$$$\$$$$\   $$$$$$$\  #
#   \____$$\ $$ |  $$ |$$  _$$  _$$\ $$  __$$\ $$  _$$  _$$\ $$  _____| #
#   $$$$$$$ |$$ |  $$ |$$ / $$ / $$ |$$ |  $$ |$$ / $$ / $$ |\$$$$$$\   #
#  $$  __$$ |$$ |  $$ |$$ | $$ | $$ |$$ |  $$ |$$ | $$ | $$ | \____$$\  #
#  \$$$$$$$ |\$$$$$$$ |$$ | $$ | $$ |$$ |  $$ |$$ | $$ | $$ |$$$$$$$  | #
#   \_______| \____$$ |\__| \__| \__|\__|  \__|\__| \__| \__|\_______/  #
#            $$\   $$ |                                                 #
#            \$$$$$$  |                                                 #
#             \______/                                                  #
#                                                                       #
# -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-#

import discord
from discord.ext import commands
from config import Config

intents = discord.Intents.default()
intents.members = True

bot = commands.Bot(command_prefix="!", intents=intents)
token = config.getToken()

epsib3_message_id = 777854216160804874
epsii1_message_id = 786186795896668200
epsii2_message_id = 786186641974624256
wisb3_message_id = 786187531615338516
wisi1_message_id = 786187622292258838
wisi2_message_id = 786187674960527370

@bot.event
async def on_ready():
    print(bot.user.name + " is ready.")


@bot.event
async def on_raw_reaction_add(payload):
    global epsib3_message_id
    global epsii1_message_id
    global epsii2_message_id
    global wisb3_message_id
    global wisi1_message_id
    global wisi2_message_id

    msg_id = payload.message_id
    guild = bot.get_guild(payload.guild_id)
    if payload.emoji.name == '💻':
        if msg_id == epsib3_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="EPSI-B3-DEVOPS"))
        elif msg_id == epsii1_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="EPSI-I1-DEVOPS"))
        elif msg_id == epsii2_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="EPSI-I2-DEVOPS"))
        elif msg_id == wisb3_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-B3-DEV"))
        elif msg_id == wisi1_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-I1-DEV"))
        elif msg_id == wisi2_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-I2-DEV"))
    elif payload.emoji.name == '⌨️':
        if msg_id == epsib3_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="EPSI-B3-SYSOPS"))
        elif msg_id == epsii1_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="EPSI-I1-SYSOPS"))
        elif msg_id == epsii2_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="EPSI-I2-SYSOPS"))
    elif payload.emoji.name == '📟':
        if msg_id == wisb3_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-B3-DATA"))
        elif msg_id == wisi1_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-I1-DATA"))
        elif msg_id == wisi2_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-I2-DATA"))
    elif payload.emoji.name == '🎨':
        if msg_id == wisb3_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-B3-UXUI"))
        elif msg_id == wisi1_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-I1-UXUI"))
        elif msg_id == wisi2_message_id:
            await payload.member.add_roles(discord.utils.get(guild.roles, name="WIS-I2-UXUI"))


@bot.event
async def on_raw_reaction_remove(payload):
    global epsib3_message_id
    global epsii1_message_id
    global epsii2_message_id
    global wisb3_message_id
    global wisi1_message_id
    global wisi2_message_id

    msg_id = payload.message_id
    guild = bot.get_guild(payload.guild_id)
    author = guild.get_member(payload.user_id)
    if payload.emoji.name == '💻':
        if msg_id == epsib3_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="EPSI-B3-DEVOPS"))
        elif msg_id == epsii1_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="EPSI-I1-DEVOPS"))
        elif msg_id == epsii2_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="EPSI-I2-DEVOPS"))
        elif msg_id == wisb3_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-B3-DEV"))
        elif msg_id == wisi1_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-I1-DEV"))
        elif msg_id == wisi2_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-I2-DEV"))
    elif payload.emoji.name == '⌨️':
        if msg_id == epsib3_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="EPSI-B3-SYSOPS"))
        elif msg_id == epsii1_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="EPSI-I1-SYSOPS"))
        elif msg_id == epsii2_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="EPSI-I2-SYSOPS"))
    elif payload.emoji.name == '📟':
        if msg_id == wisb3_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-B3-DATA"))
        elif msg_id == wisi1_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-I1-DATA"))
        elif msg_id == wisi2_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-I2-DATA"))
    elif payload.emoji.name == '🎨':
        if msg_id == wisb3_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-B3-UXUI"))
        elif msg_id == wisi1_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-I1-UXUI"))
        elif msg_id == wisi2_message_id:
            await author.remove_roles(discord.utils.get(guild.roles, name="WIS-I2-UXUI"))

bot.run(token)

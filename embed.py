import discord

def sendEmbed(question="No joke", info="no info"):
    embed=discord.Embed(description="-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
    embed.add_field(name=question, value="-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-", inline=False)
    embed.add_field(name=info, value=".", inline=False)
    embed.set_footer(text="BotFouras v1.0.0 by aymerick michelet")
    return embed


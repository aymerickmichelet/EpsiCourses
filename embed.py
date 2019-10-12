import discord

def sendEmbed(author="author.error", joke="joke.error", info="info.error"):
    info+=" | BotLeFlip v1.0.0 by aymerick michelet"
    embed=discord.Embed(title=joke, color=0x80ffff)
    embed.set_author(name=author)
    embed.set_footer(text=info)
    return embed
<template>
	<v-row justify="center" align="center">
		<v-col cols="12" sm="8" md="6">
			<v-card class="logo py-4 d-flex justify-center">
				<EMairieLogo />
			</v-card>
			<v-card>
				<v-card-title class="headline text-center">
					Bienvenue dans la bêta de l'application eMairie !
				</v-card-title>
				<v-card-text>
					<p>L'application eMairie vous permettra de consulter depuis partout les posts de votre commune avec ou sans connexion et sur n'importe quel appareil ! Cette application est encore en développement et de nombreuses fonctionnalitées propre à cette dernière arriveront bientôt ! Merci pour votre confiance !</p>
					<p>
						Pour plus de détails, merci de vous rendre sur <a
							href="https://emairie.aymerickmichelet.fr"
							target="_blank"
							rel="noopener noreferrer"
						>
							eMairie
						</a>.
					</p>
					<div class="text-xs-right">
						<em><small>&mdash; Julien MARFELLA et Aymerick MICHELET</small></em>
					</div>
					<hr class="my-3">
					<a
						href="https://github.com/eMairie/website"
						target="_blank"
						rel="noopener noreferrer"
					>
						eMairie WebSite Github
					</a>
					<br>
					<a
						href="https://github.com/eMairie/API"
						target="_blank"
						rel="noopener noreferrer"
					>
						eMairie API Github
					</a>
				</v-card-text>
			</v-card>
		</v-col>
	</v-row>
</template>

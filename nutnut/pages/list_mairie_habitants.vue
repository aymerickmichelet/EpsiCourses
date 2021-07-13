<template>
	<v-row justify="center" align="center">
		<v-col cols="12" sm="8" md="6">
			<v-card class="pa-2">
				<v-card-title class="headline">
					Liste des habitants d'une mairie
				</v-card-title>
				<v-col
					cols="12"
					sm="6"
				>
				</v-col>
				<v-card-actions>
					<v-spacer />
					<v-btn
						color="primary"
						nuxt
						@click="$fetch"
					>
						Actualiser
					</v-btn>
				</v-card-actions>
			</v-card>
			<v-card class="ma-5" elevation="10">
				<v-card-title class="headline">
					Information sur la réponse de la requête:
				</v-card-title>
				<v-card-text>
					<ul>
						<li>Réponse: {{ this.response }}</li>
						<li>Message de debug: {{ this.debug }}</li>
						<li>Nombre d'habitants: {{ this.numberUsers }}</li>
					</ul>
				</v-card-text>
			</v-card>
			<v-card class="ma-5" elevation="10" v-for="user in users" :key="user">
				<v-card-title class="headline">
					Id de l'habitant: {{ user.id }}
				</v-card-title>
				<v-card-text>
					<ul>
						<li>Id du statut de l'habitant: {{ user.statut_id }} </li>
						<li>Id de la mairie de l'utilisateur: {{ user.mairie_id }} </li>
						<li>Email: {{ user.email }} </li>
						<li>Role: {{ user.roles }} </li>
						<li>UUID de l'utilisateur: {{ user.uuid_user }} </li>
						<li>Pseudonyme: {{ user.pseudonym }} </li>
						<li>Lien de l'image de profile: {{ user.profile_picture_link }} </li>
						<li>Achat de l'offre premium ?: {{ user.premium }} </li>
					</ul>
				</v-card-text>
			</v-card>
		</v-col>
	</v-row>
</template>

<script>
export default {
	data () {
		return {
			response: 'null',
			debug: 'null',
			numberUsers: 'error',
			users: []
		}
	},
	async fetch () {
		const requestResponse = await fetch(
			'https://api-emairie.thejulienm.fr/list_mairie_habitants.php?id_mairie=1'
		).then(res => res.json())

		this.response = requestResponse.response
		this.debug = requestResponse.debug
		this.numberUsers = requestResponse.habitants
		this.users = requestResponse.list
	}
}
</script>

<template>
	<v-row justify="center" align="center">
		<v-col cols="12" sm="8" md="6">
			<v-card class="pa-2">
				<v-card-title class="headline">
					Liste des postes d'une mairie
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
						<li>Nombre de poste: {{ this.numberPosts }}</li>
					</ul>
				</v-card-text>
			</v-card>
			<v-card class="ma-5" elevation="10" v-for="post in posts" :key="post">
				<v-card-title class="headline">
					Id du poste: {{ post.id }}
				</v-card-title>
				<v-card-text>
					<ul>
						<li>Id de la mairie: {{ post.mairie_id }} </li>
						<li>Id de l'utilisateur: {{ post.user_id }} </li>
						<li>uuid post: {{ post.uuid_post }} </li>
						<li>Lien de l'image: {{ post.image_link }} </li>
						<li>Date de création de l'image: {{ post.date_creation }} </li>
						<li>Contenu du poste: {{ post.content }} </li>
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
			numberPosts: 'error',
			posts: [],
			input_mairie: 'wesh'
		}
	},
	async fetch () {
		const requestResponse = await fetch(
			'https://api-emairie.thejulienm.fr/list_mairie_posts.php?id_mairie=1'
		).then(res => res.json())

		this.response = requestResponse.response
		this.debug = requestResponse.debug
		this.numberPosts = requestResponse.posts
		this.posts = requestResponse.list
	}
}
</script>

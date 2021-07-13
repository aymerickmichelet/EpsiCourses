<template>
	<v-row justify="center" align="center">
		<v-col cols="12" sm="8" md="6">
			<v-card class="pa-2">
				<v-card-title class="headline">
					Détail d'un poste
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
					</ul>
				</v-card-text>
			</v-card>
			<v-card class="ma-5" elevation="10">
				<v-card-title class="headline">
					Id du poste: {{ this.post.id }}
				</v-card-title>
				<v-card-text>
					<ul>
						<li>Id de la mairie: {{ this.post.mairie_id }} </li>
						<li>Id de l'utilisateur: {{ this.post.user_id }} </li>
						<li>uuid post: {{ this.post.uuid }} </li>
						<li>Lien de l'image: {{ this.post.image_link }} </li>
						<li>Date de création de l'image: {{ this.post.date_creation }} </li>
						<li>Nombre de commentaire: {{ this.post.numberComments }} </li>
						<li>Nombre de likes: {{ this.post.numberLikes }} </li>
						<li>Contenu du poste: {{ this.post.content }} </li>
					</ul>
				</v-card-text>
			</v-card>
			<v-card class="ma-10" elevation="10" v-for="comment in comments" :key="comment">
				<v-card-title class="headline">
					Id du commentaire: {{ comment.id }}
				</v-card-title>
				<v-card-text>
					<ul>
						<li>Id du poste : {{ comment.post_id }} </li>
						<li>Id de l'utilisateur: {{ comment.user_id }} </li>
						<li>uuid du commentaire: {{ comment.uuid_comment }} </li>
						<li>Date de création du commentaire: {{ comment.date_creation }} </li>
						<li>Contenu du commentaire: {{ comment.content }} </li>
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
			post: {
				numberComments: -1,
				numberLikes: -1,
				date_creation: -1,
				image_link: 'null',
				content: 'null',
				uuid: 'null',
				user_id: -1,
				mairie_id: -1,
				id: -1
			},
			comments: []
		}
	},
	async fetch () {
		const requestResponse = await fetch(
			'https://api-emairie.thejulienm.fr/list_post_details.php?id_post=7'
		).then(res => res.json())

		this.response = requestResponse.response
		this.debug = requestResponse.debug
		this.post.numberComments = requestResponse.commentcount
		this.post.numberLikes = requestResponse.likecount
		this.post.date_creation = requestResponse.date_creation
		this.post.image_link = requestResponse.image_link
		this.post.content = requestResponse.content
		this.post.uuid = requestResponse.uuid_post
		this.post.user_id = requestResponse.user_id
		this.post.mairie_id = requestResponse.mairie_id
		this.post.id = requestResponse.id
		this.comments = requestResponse.comments
	}
}
</script>

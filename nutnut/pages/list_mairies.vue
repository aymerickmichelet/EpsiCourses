<template>
	<v-row justify="center" align="center">
		<v-col cols="12" sm="8" md="6">
			<v-card>
				<v-card-title class="headline">
					Liste des mairies partenaires
				</v-card-title>
				<v-card-text>
					<p v-if="$fetchState.pending">Récupération des mairies... </p>
					<p v-else-if="$fetchState.error">Une erreur est survenue :( </p>
					<ul v-else v-for="mairie in mairies.list" :key="mairie">
						<li> {{ mairie.ville }} </li>
					</ul>
				</v-card-text>
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
		</v-col>
	</v-row>
</template>

<script>
export default {
	data () {
		return {
			mairies: []
		}
	},
	async fetch () {
		this.mairies = await fetch(
			'https://api-emairie.thejulienm.fr/list_mairies.php'
		).then(res => res.json())
	}
}
</script>

import styles from './card.module.css'

export default async function Details({ params }) {
	console.log("esse e o id enviado: ", params.id)

	const card = await fetch(`http://localhost:5237/api/Destino/${params.id}`).then((res) =>
		res.json(),
	)


	return (
		<div className={styles.container}>
			<div className={styles.card}>
				<img src={card.destinoUrl} alt={card.title} />
				<div className={styles.card_title}>
					<p>{card.nome}</p>
				</div>
			</div>
		</div>
	)
}


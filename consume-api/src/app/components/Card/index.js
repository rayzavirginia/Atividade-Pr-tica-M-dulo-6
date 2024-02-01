import Link from 'next/link'
import styles from './card.module.css'

export default async function Card() {
	const cards = await fetch('http://localhost:5237/api/Destino').then((res) =>
		res.json(),
	)
	console.log(cards)

	return (
		<div className={styles.container}>
      {cards?.map((card) => (
        <div key={card.id} className={styles.card}>
          <img src={card.destinoUrl} alt={card.nome} />
          <div className={styles.card_content}>
            <p className={styles.card_title}>{card.nome}</p>
            <p>{card.estado}</p>
            <p>{card.pais}</p>
            <p className={styles.valor}>{card.valor}</p>
          </div>
          <div className={styles.button_container}>
            <Link
              className={styles.button_link}
              href={`/Details/[id]`}
              as={`/Details/${card.id}`}
            >
              +
            </Link>
          </div>
        </div>
      ))}
    </div>

	)
}

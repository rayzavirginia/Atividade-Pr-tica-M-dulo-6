import Link from 'next/link'



export default function Header() {
	return (
		<header className="header">
			<img src="/logo feriascom.svg" alt="logo" />
			<ul>
				<li>
					<Link href="/RotaUm">Destinos</Link>
				</li>
				<li>
					<Link href="/RotaDois">Pacotes</Link>
				</li>
				<li>
					<Link href="/RotaTres">Contato</Link>
				</li>
			</ul>
		</header>
	)
}
import Footer from './components/Footer'
import Header from './components/Header'
import './globals.css'

export default function RootLayout({ children }) {
	return (
		<html lang="en">
			<body>
				<Header />
				<main>{children}</main>
        <Footer/>
			</body>
		</html>
	)
}

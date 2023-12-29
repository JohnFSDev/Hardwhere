import "../Styles/Header.css";
import SearchBar from "./Search.tsx";

function Header() {
  return (
    <header>
      <img className="logo" src="../logo.png"></img>
      <nav>
        <div className="buscar">
          <SearchBar />
        </div>
        <a href="#QuuEs">Que es Hardwhere?</a>
      </nav>
    </header>
  );
}

export default Header;

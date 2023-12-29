import { useState } from "react";
import { FaSearch } from "react-icons/fa";
import "../styles/SearchBar.css";

function SearchBar() {
  return (
    <div className="SearchBarWrap">
      <FaSearch id="search-icon" />
      <input placeholder="Buscar" />
    </div>
  );
}

export default SearchBar;

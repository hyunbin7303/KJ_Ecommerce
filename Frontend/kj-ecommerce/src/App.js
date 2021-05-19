import "./App.css";
import HomePage from "./Components/Pages/HomePage/HomePage";
import ReactAux from "./Hoc/ReactAux/ReactAux";
import Layout from "./Hoc/Layout/Layout";

function App() {
  return (
    <ReactAux>
      <Layout>
        <div className="h1">KJ Ecommerce</div>
        <HomePage />
      </Layout>
    </ReactAux>
  );
}

export default App;

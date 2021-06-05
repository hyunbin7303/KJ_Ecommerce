import "./App.css";
import HomePage from "./Components/Pages/HomePage/HomePage";
import ReactAux from "./Hoc/ReactAux/ReactAux";
import Layout from "./Hoc/Layout/Layout";
import { Route, Switch } from "react-router-dom";
import CartPage from './Components/Pages/CartPage/CartPage';
import OrderPage from "./Components/Pages/OrderPage/OrderPage";

function App() {
  return (
    <ReactAux>
      <Layout>
        <Switch>
          <Route path="/cart" component={CartPage} />
          <Route path="/orders" component={OrderPage} />
          <Route path="/" exact component={HomePage} />
        </Switch>
      </Layout>
    </ReactAux>
  );
}

export default App;

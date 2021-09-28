import React from 'react';
import MenuDrawer from './LayoutStructure/MenuDrawer/MenuDrawer';

import TopBar from './LayoutStructure/TopBar/TopBar';
import Main from './LayoutStructure/Main/Main';
import './App.css';

import 'primeflex/primeflex.css';
import 'primereact/resources/themes/bootstrap4-dark-blue/theme.css'
import 'primereact/resources/primereact.min.css'
import 'primeicons/primeicons.css'

const App = () => {


  return (
    <>      
      <TopBar />

      <Main />

    </>

  );
}

export default App;

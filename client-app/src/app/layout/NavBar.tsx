import React from "react";
import { Menu, Container, Button } from "semantic-ui-react";

export default function NavBar() {
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: '10px'}}/>
                    Reactividades
                </Menu.Item>
                <Menu.Item name='Actividades' />
                <Menu.Item>
                <Button positive content='Crear actividad'/>
                </Menu.Item>   
            </Container>
        </Menu>
    )
}
import React, { useState } from "react"
import { StyleSheet, Text, View, Image, Dimensions } from "react-native"

import picMountain from "./assets/gray-asphalt-road-on-cliff.jpg"
import picCave from "./assets/abstract-antelope-canyon-art-blur.jpg"

export default function App(){
  const [backgroundColor, setBackgroundColor] = useState("blue");
  return(
    <View style={[styles.container, { backgroundColor }]}>
      <Text style={styles.button}
        onPress={() => setBackgroundColor("green")}
        >green</Text>
      <Text style={styles.button}
        onPress={() => setBackgroundColor("red")}
        >red</Text>
    </View>
  )
} 

const styles = StyleSheet.create({
  container: {
    flex: 1,
    display: "flex",
    justifyContent: "center",
    alignItems: "center"
  },
  button: {
    fontSize: 30,
    margin: 10,
    padding: 10
  }
})
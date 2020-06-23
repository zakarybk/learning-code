import React, { useState } from "react"
import { StyleSheet, Text, View, TouchableHighlight } from "react-native"

import picMountain from "./assets/gray-asphalt-road-on-cliff.jpg"
import picCave from "./assets/abstract-antelope-canyon-art-blur.jpg"

export default function App(){
  const [backgroundColor, setBackgroundColor] = useState("blue");
  return(
    <View style={[styles.container, { backgroundColor }]}>
      <TouchableHighlight style={styles.button}
        onPress={() => setBackgroundColor("yellow")}
        underlayColor="orange">
        <View style={styles.row}>
          <View style={[styles.sample, { backgroundColor: "yellow" }]} />
          <Text style={styles.buttonText}>yellow</Text>
        </View>
      </TouchableHighlight>
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
    margin: 10,
    padding: 10,
    borderWidth: 2,
    borderRadius: 10,
    alignSelf: "stretch",
    backgroundColor: "rgba(255,255,255,0.8)"
  },
  buttonText: {
    fontSize: 30,
    textAlign: "center"
  },
  row: {
    flexDirection: "row",
    alignItems: "center"
  },
  sample: {
    height: 20,
    width: 20,
    borderRadius: 10,
    backgroundColor: "white"
  }
})